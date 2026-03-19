using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            string typed_msg;

            typed_msg = this.TextBox.Text;

            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                this.ListBox.Items.Add(typed_msg);

                this.TextBox.Clear();
                this.TextBox.Focus();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}