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
    public partial class Form1 : Form
    {

        //vì được parsing qua lại giữa nhiều function, thậm chí là async, nên các biến này sẽ được khai báo GLOBAL 
        IPEndPoint ipe;
        TcpClient tcpclient;
        Stream stream;
        string plainResult;

        //hàm init 
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        //gửi đi dữ liệu cần tìm kiếm 
        private void btSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        //kết nối với server 
        void Connect()
        {
            try
            {
                tcpclient = new TcpClient();
                ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                tcpclient.Connect(ipe);
                stream = tcpclient.GetStream();
                Thread recv = new Thread(Receive);
                recv.IsBackground = true;
                recv.Start();
            }
            catch
            {
                MessageBox.Show("The server refused to connect, please try again later");
                return;
            }
        }

        //hàm gửi đi chuỗi cần tìm 
        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
            stream.Write(data, 0, data.Length);
            searchedList.Items.Add(tbMessage.Text);
        }

        //nhận lại chuỗi trả về từ từ điển 
        //dưới dạng plain HTML, cần lọc lại và render thành các chuỗi phù hợp 
        void Receive()
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                plainResult = Encoding.UTF8.GetString(recv);
                plainResult = plainResult.Replace("+", ": ");
                plainResult = plainResult.Replace("=", " ");
                ResolveResult(plainResult);
            }
        }

        //phân giải chuỗi HTML trả về để hiển thị thích hợp 
        void ResolveResult(String plainResult)
        {
            string[] splitter = { "<br />" };
            string[] temp = plainResult.Split(splitter, StringSplitOptions.None);
            foreach (string item in temp)
            {
                if (item.Contains("*"))
                {
                    wordType.Text += item + "\n";
                }
                if (item.Contains("-"))
                {
                    meanInput.Text = item;
                    break;
                }
            }
            webBrowser1.DocumentText = plainResult ;
        }
   
       
       

    }
}
