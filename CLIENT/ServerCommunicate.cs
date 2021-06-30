using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Web;

namespace CLIENT
{
    class ServerCommunicate
    {

        #region VariableDeclaration

        TcpClient tcpclient;
        Stream stream;
        string plainResult;
        string meaning;
        string type;
        WebBrowser browser;
        int count;
        #endregion

        #region ConnectToServer

        public void Connect(WebBrowser webBrowser, int counter, string serverIP, Button connectBtn)
        {
            //thiết lập IP mới và các thông số đầu vào cần thiết
            IPEndPoint ipe;
            browser = webBrowser;
            count = counter;

            try
            {
                //thực hiện kết nối
                tcpclient = new TcpClient();
                try
                {

                    ipe = new IPEndPoint(IPAddress.Parse(serverIP), 9999);
                    tcpclient.Connect(ipe);
                    connectBtn.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Your IP address is probably wrong, please check it out ");
                    return;
                }

                //tạo thread mới để truyền dữ liệu
                stream = tcpclient.GetStream();

                //nếu server trả về true thì connect, báo ra cho người dùng biết
                Thread recv = new Thread(Receive);
                recv.IsBackground = true;
                recv.Start();
                MessageBox.Show("Connected !");
                
            }
            catch
            {
                //nếu có bất kỳ lỗi nào, báo ra rằng không thể kết nối
                MessageBox.Show("The server refused to connect, please try again later");
                return;
            }
        }
        #endregion

        #region Send&Receive&CloseConnection

        public void Send(ListView searchedList, string message)
        {
            //gửi đata đi 
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);

            //hiện lên trên danh sách những từ đã tìm kiếm
            searchedList.Items.Add("- " + message);
        }

        public void Receive()
        {
            try
            {
                while (true)
                {
                    //nhận dữ liệu thô từ server
                    byte[] recv = new byte[1024];
                    stream.Read(recv, 0, recv.Length);
                    plainResult = Encoding.UTF8.GetString(recv);

                    //nếu string có chứa not found, hiển thị lên 
                    if (plainResult == "" )
                    {
                        MessageBox.Show("Not found ! Please try with another word");
                        return;
                    }
                    //chia kết quả vào những thành phần phủ hợp để render ra giao diện
                    ResolveResult();
                }
            }
            catch
            {
                //nếu không thể nhận data được 
                MessageBox.Show("Cannot fetch data from server, please try again ");
            }

        }

        public void CloseConnection()
        {
            tcpclient.GetStream().Close();
            tcpclient.Close();
        }  

        #endregion

        #region HandleDataString
        public void ResolveResult()
        {
            //replace những thành phần thừa mà server trả về 
            plainResult = plainResult.Replace("+", ": ");
            plainResult = plainResult.Replace("=", " ");

            //dạng trả về là HTML, nên sẽ có những tag br. tag br ký hiệu cho xuống dòng 
            string[] splitter = { "<br />" };
            string[] temp = plainResult.Split(splitter, StringSplitOptions.None);

            //lặp qua mảng temp - nơi lưu dữ liệu đã được cắt thành từng dòng 
            //dấu * đầu dòng ký hiệu cho loại từ 
            //dấu - ký hiệu cho nghĩa của từ 
            foreach (string item in temp)
            {
                if (item.Contains("*"))
                {
                    type = item;
                }

                if (item.Contains("-"))
                {
                    meaning = item;
                    break;
                }
            }

            //hiển thị toàn bộ data ra browser 
            browser.DocumentText = plainResult;
        }
        #endregion

        #region GetDataToDisplay
        public string GetMeaning()
        {
            return meaning;
        }

        public string GetWordType()
        {
            return type;
        }
        #endregion
    }
}
