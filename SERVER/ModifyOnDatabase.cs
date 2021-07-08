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
    public partial class ModifyOnDatabase : Form
    {
        string word;
        string meaning;
        string dbName;
        string dbUID;
        string dbPassword;
        public ModifyOnDatabase(string Name, string UID, string Pass, string Word, string Meaning)
        {
            InitializeComponent();
            word = Word;
            meaning = Meaning;
            dbName = Name;
            dbUID = UID;
            dbPassword = Pass;
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {         
            //thiết lập connection mới cho mySQL 
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=" + dbName + ";uid=" + dbUID + ";password=" + dbPassword);


            MySqlCommand cmd = dbConn.CreateCommand();


            cmd.CommandText = "update tbl_edict set detail='" + meaning + "' where word='" + word + "';";
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

            // đóng database
            dbConn.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            return;

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
