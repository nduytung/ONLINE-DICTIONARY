using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using MySql.Data.MySqlClient;

namespace SERVER
{

    //CODE XONG NHO DETACH TAT CA CODE 
    //FORMAT LAI SAU 
    public partial class Server : Form
    {
        //tương tự như phía CLIENT, các biến này được khai báo GLOBAL để tiện cho parsing và chạy async 
        IPEndPoint ipe;
        Socket client;
        TcpListener tcplistener;
        string input;
        string output;

        //hàm init 
        public Server()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //handle phím kết nối 
        private void connectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        //hàm thực hiện kết nối 
        void Connect()
        {
            try
            {

                ipe = new IPEndPoint(IPAddress.Any, 9999);
                tcplistener = new TcpListener(ipe);
                Thread thread = new Thread(() =>
                {
                    while (true)
                    {
                        tcplistener.Start();
                        client = tcplistener.AcceptSocket();
                        Thread rec = new Thread(Receive);
                        rec.IsBackground = true;
                        rec.Start(client);
                    }
                });

                thread.IsBackground = true;
                thread.Start();
                richTextBox1.Text += ("Server is now ready \n");

            }
            catch
            {
                MessageBox.Show("please try again later");
            }
        }

        //hàm trả về dữ liệu cho user 
        //dữ liệu được trả về là 1 chuỗi HTML plain text 
        void Send(Socket client)
        {
            try
            {

                byte[] outputByte = Encoding.UTF8.GetBytes(output);
                client.Send(outputByte);
            }
            catch
            {
                MessageBox.Show("Disconnected");
            }
        }

        //nhận chuỗi từ phía client 
        void Receive(Object obj)
        {
            try
            {

                while (true)
                {

                    Socket client = obj as Socket;
                    byte[] clientMsg = new byte[1024];
                    client.Receive(clientMsg);
                    input = Encoding.UTF8.GetString(clientMsg);
                    textBox1.Text = input;
                    listView1.Items.Add(input);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch
            {
                MessageBox.Show("erroe");
            }



        }

        //thực hiện tìm kiếm 
        //ASYNC, nên phải sử dụng background worker 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=dictionarydb;uid=root;password=REACTer_1611");
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_edict WHERE word='" + textBox1.Text + "'";
            cmd.CommandType = CommandType.Text;

            // thử mửo DB 
            try
            {
                dbConn.Open();
            }

            catch (Exception err)
            {
                MessageBox.Show("Error ! " + err);
                this.Close();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                output += reader[2].ToString() + "\n";
                break;
            }

            dbConn.Close();

        }

        //hiển thị sau khi tìm kiếm hoàn tất 
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            richTextBox1.Text = "STATUS: DONE \n" + output;
            Send(client);
        }


        //hiển thị khi có thay đổi trong backgroundworker
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


    }
}
