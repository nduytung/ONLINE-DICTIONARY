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
    public partial class Server : Form
    {
      
        #region VariableDeclaration
        IPEndPoint ipe;
        Socket client;
        TcpListener tcplistener;
        string input;
        string output;
        #endregion

        #region Initialize
        public Server()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region ButtonEventHandlers
        private void connectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }

        #endregion

        #region ClientContact
        //hàm thực hiện kết nối 
        void Connect()
        {
            try
            {
                //tạo 1 IP Endpoint mới 
                ipe = new IPEndPoint(IPAddress.Any, 9999);
                tcplistener = new TcpListener(ipe);

                //tạo thread mới để nhận dữ liệu 
                //sử dụng arrow function để invok hàm chỉ khi ấn button, nếu không nó sẽ thành IIFE 
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
                //nếu kết nối thành công thì hiển thị ra cho user
                MessageBox.Show("Connect successfully !");

            }
            catch
            {
                MessageBox.Show("Please try again later");
            }
        }


        void Send(Socket client)
        {
            try
            {
                //mã hóa chuỗi thành các byte để gửi 
                byte[] outputByte = Encoding.UTF8.GetBytes(output);
                client.Send(outputByte);

                //làm trống output, sẵn sàng nhận dữ liệu tiếp theo từ user 
                output = null;
            }
            catch
            {
                //nếu không nhận được gì => đã đứt kết nối
                MessageBox.Show("Disconnected");
            }
        }

        void Receive(Object obj)
        {
            try
            {
                while (true)
                {
                    //nhận dữ liệu từ người dùng ở dạng byte
                    Socket client = obj as Socket;
                    byte[] clientMsg = new byte[1024];
                    client.Receive(clientMsg);

                    //mã hóa nó thành chuỗi
                    input = Encoding.UTF8.GetString(clientMsg);

                    //hiển thị vào danh sách đã nhận và màn hình trạng thái 
                    textBox1.Text = input;
                    listView1.Items.Add(input);
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch
            {
                MessageBox.Show("No signal, please try again");
            }



        }
        #endregion

        #region BackgroundWorkerHandlers
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //thiết lập connection mới cho mySQL 
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=dictionarydb;uid=root;password=REACTer_1611");
            MySqlCommand cmd = dbConn.CreateCommand();

            //thiết lập câu lệnh truy vấn từ database 
            cmd.CommandText = "SELECT * from tbl_edict WHERE word='" + textBox1.Text + "'";
            cmd.CommandType = CommandType.Text;

            // thử mở database 
            try
            {
                dbConn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Cannot open database. Error: " + err);
                this.Close();
            }

            //đọc database và thực hiện truy vấn 
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //bỏ đi thành phần đầu và thứ 2, đọc từ vị trí thứ 3, vì 2 vị trí đầu là từ cần tìm, dữ liệu thừa 
                output += reader[2].ToString() + "\n";
                break;
            }


            //đóng database 
            dbConn.Close();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //hiển thị sau khi tìm kiếm hoàn tất 
            //gửi đi cho client 
            richTextBox1.Text = "\n STATUS: DONE \n" + output;
            Send(client);
        }


        //hiển thị khi có thay đổi trong backgroundworker
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }
        #endregion

    }
}
