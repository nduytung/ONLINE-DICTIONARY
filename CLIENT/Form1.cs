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
        string language = "Vie";
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
            server.Connect(webBrowser1, count, serverIP.Text, connectBtn);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (serverIP.Text.Contains("Server IP"))
            {
                MessageBox.Show("Please fill in IP address");
                return;
            }
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
            try
            {
                MessageBox.Show("Please create a 'report' file on your Desktop");
                var name = "report.xlsx";
                var dicrec = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var fullpath = Path.Combine(dicrec, name);
                Excel excel = new Excel(fullpath, 1);
                excel.WriteToCell(1, 1, "TỪ VỤNG", "LOẠI TỪ", "NGHĨA CỦA TỪ");
                excel.WriteToCell(count, 1, tbMessage.Text, server.GetWordType(), server.GetMeaning());
                count++;
                excel.Save();
                excel.Close();
                MessageBox.Show("Write successfully !");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Make sure the file 'report' exists!");
            }
        }


        private void languageBtn_Click(object sender, EventArgs e)
        {
            if (language == "Eng")
            {
                searchBtn.Text = "TÌM";
                stopBtn.Text = "DỪNG";
                viewMeaningBtn.Text = " Xem nghĩa từ";
                viewTypeBtn.Text = " Xem loại từ";
                exportExcelBtn.Text = " Xuất file Excel";
                wordListTitle.Text = " Danh sách từ";
                wordDetail.Text = "Chi tiết từ";
                languageBtn.Text = "Vie";
                language = "Vie";
            } else if (language == "Vie")
            {
                searchBtn.Text = "SEARCH";
                stopBtn.Text = "STOP";
                viewMeaningBtn.Text = " View meaning";
                viewTypeBtn.Text = " View word type";
                exportExcelBtn.Text = " Export to Excel";
                wordListTitle.Text = " Searched list";
                wordDetail.Text = "Word details";
                languageBtn.Text = "Eng";
                language = "Eng";
            }
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
