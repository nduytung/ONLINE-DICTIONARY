using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class NewWordSub : Form
    {
        ServerCommunicate server = new ServerCommunicate();
        public string word { get; set; }
        public string meaning { get; set; }
        public string type { get; set; }
        public NewWordSub(string a)
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "" || richTextBox3.Text == "")
            {
                MessageBox.Show("Please fill in type and word detail");
                return;
            }
            this.word = richTextBox1.Text;
            this.type = richTextBox2.Text;
            this.meaning = richTextBox3.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

            MessageBox.Show("'" + word + "'" + " has been submitted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
