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
        int count = 1;
        ServerCommunicate server = new ServerCommunicate();
        #endregion

        //hàm init 
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            server.Connect(webBrowser1);
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
            Excel excel = new Excel(@"C:\DATA\Save.xlsx", 1);

            count++;
            excel.WriteToCell(count, 1, tbMessage.Text, server.GetWordType(), server.GetMeaning());

            excel.Save();
            excel.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            server.Send(tbMessage.Text, searchedList);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            server.CloseConnection();
        }

    }
}
