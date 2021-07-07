using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SERVER
{
    public partial class NewWordList : Form
    {
        string dbName;
        string dbUID;
        string dbPassword;
        
        List<string> Lio;
        List<newWord> list = new List<newWord>();
        public NewWordList(string name, string UID, string Pass, List<string> LioNW)
        {
            InitializeComponent();
            dbName = name;
            dbUID = UID;
            dbPassword = Pass;
            Lio = LioNW;
            AddStrListObject(LioNW);

        }

        private void AddStrListObject(List<string> str_list)
        {
            foreach (string item in str_list)
            {
                string[] splitter = { "@%$" };
                string[] temp = item.Split(splitter, StringSplitOptions.None);

                list.Add(new newWord() { word = temp[0], type = temp[1], meaning = temp[2] });
                comboBox1.Items.Add(new newWord() { word = temp[0], type = temp[1], meaning = temp[2] });
            }
            
            
            comboBox1.DisplayMember = "word";
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //thiết lập connection mới cho mySQL 
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=" + dbName + ";uid=" + dbUID + ";password=" + dbPassword);
            MySqlCommand cmd = dbConn.CreateCommand();

            //thiết lập câu lệnh truy vấn từ database 
            cmd.CommandText = "INSERT INTO dic.tbl_edict (word,detail) VALUES ('"+richTextBox1.Text+ "','<C><F><I><N><Q>@"+richTextBox1.Text+ "<br />*" + richTextBox2.Text+ "<br />-" + richTextBox3.Text+ "');";
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




            MessageBox.Show("Word added to database");
            //đóng database 
            dbConn.Close();
        }

        public List<string> getList() { return Lio; }

        //call event add to dataBase
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> _Lio = Lio;
            List<newWord> _list = list;
            backgroundWorker1.RunWorkerAsync();
            if (comboBox1.Items.Count > 0 )
            {
                foreach(newWord re in _list)
                {
                    if (re.word == comboBox1.Text)
                    {
                        //remove item that done added
                        comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                        //update Lio string
                        //foreach (string li in _Lio)
                            //if (li.Contains(comboBox1.Text)) _Lio.Remove(li);
                        ////update list string
                        //_list.Remove(re);
                    }   
                    
                }
                Lio = _Lio;
                list = _list;
            }
            else MessageBox.Show("Nothing to add");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            newWord ne = comboBox1.SelectedItem as newWord;
            richTextBox1.Text = ne.word;
            richTextBox2.Text = ne.type;
            richTextBox3.Text = ne.meaning;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            return;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }
    }
}
