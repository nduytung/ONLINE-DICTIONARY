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

        #region VariableDeclaration
        int count = 2;
        ServerCommunicate server = new ServerCommunicate();
        #endregion

        #region Initialize 
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion


        #region ButtonClickEvents

        private void connectBtn_Click(object sender, EventArgs e)
        {
            server.Connect(webBrowser1, count, serverIP.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            server.Send(searchedList, tbMessage.Text);

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            server.CloseConnection();
        }

        private void viewMeaningBtn_Click(object sender, EventArgs e)
        {
            displayInput.Text = server.GetMeaning();
        }

        private void viewTypeBtn_Click(object sender, EventArgs e)
        {
            displayInput.Text = server.GetWordType();
        }

        private void exportExcelBtn_Click(object sender, EventArgs e)
        {
            //add to excel 
            Excel excel = new Excel(@"C:\Users\nduyt\Downloads\Word.xlsx", 1);

            excel.WriteToCell(count, 1, tbMessage.Text, server.GetWordType(), server.GetMeaning());
            count++;
            excel.Save();
            excel.Close();
            MessageBox.Show("Write successfully !");
        }



        #endregion

       
    }
}
