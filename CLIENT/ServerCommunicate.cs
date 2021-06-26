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

        IPEndPoint ipe;
        TcpClient tcpclient;
        Stream stream;
        string plainResult;
        string meaning;
        string type;
        int count = 1;

        public void Connect(WebBrowser webBrowser1)
        {
            try
            {
                tcpclient = new TcpClient();
                ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                tcpclient.Connect(ipe);
                stream = tcpclient.GetStream();
                Thread recv = new Thread(() => Receive(webBrowser1));
                recv.IsBackground = true;
                recv.Start();
                MessageBox.Show("Connected !");
            }
            catch
            {
                MessageBox.Show("The server refused to connect, please try again later");
                return;
            }
        }

        public void Send(string message, ListView searchedList)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            searchedList.Items.Add(message);
        }

        //nhận lại chuỗi trả về từ từ điển 
        //dưới dạng plain HTML, cần lọc lại và render thành các chuỗi phù hợp 
        public void Receive(WebBrowser webBrowser1)
        {
            try
            {
                while (true)
                {

                    byte[] recv = new byte[1024];
                    stream.Read(recv, 0, recv.Length);
                    plainResult = Encoding.UTF8.GetString(recv);
                    plainResult = plainResult.Replace("+", ": ");
                    plainResult = plainResult.Replace("=", " ");

                    ResolveResult(plainResult, webBrowser1);
                }
            }
            catch
            {
                MessageBox.Show("Disconnected ");
            }

        }

        public void ResolveResult(String plainResult, WebBrowser webBrowser1)
        {
            string[] splitter = { "<br />" };
            string[] temp = plainResult.Split(splitter, StringSplitOptions.None);
            foreach (string item in temp)
            {
                if (item.Contains("*"))
                {
                    type = item;
                    count++;
                }
                if (item.Contains("-"))
                {
                    meaning = item;
                    count++;
                    break;
                }
            }
            webBrowser1.DocumentText = plainResult;
        }

        public void CloseConnection ()
        {
            tcpclient.GetStream().Close();
            tcpclient.Close();
        }

        public string GetMeaning ()
        {
            return meaning;
        }

        public string GetWordType ()
        {
            return type;
        }
    }
}
