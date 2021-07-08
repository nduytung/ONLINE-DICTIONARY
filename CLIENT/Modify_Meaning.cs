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
    public partial class Modify_Meaning : Form
    {
        ServerCommunicate server = new ServerCommunicate();
        public Modify_Meaning()
        {
            InitializeComponent();
        }
        public Modify_Meaning(string word, string serverIP, string meaning)
        {
            InitializeComponent();
            textBox1.Text = word;
            textBox1.Enabled = false;
            textBox2.Text = serverIP;
            textBox2.Enabled = false;
            richTextBox1.Text = meaning;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            server.Connect_to_Modify(textBox2.Text);
            server.Send_To_Modify(textBox1.Text, richTextBox1.Text);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
