using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void Button_Click(object sender, EventArgs e)
        {
            if (this.TextBox.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자까지만 입력 가능합니다!", "경고");
                return; 
            }

            string typed_msg = this.TextBox.Text.Trim();

            typed_msg = this.TextBox.Text;

            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {typed_msg}";
                this.ListBox.Items.Add(result);

                this.TextBox.Clear();
                this.TextBox.Focus();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = this.ListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("이 메시지를 삭제할까요?", "삭제 확인", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.ListBox.Items.RemoveAt(selectedIndex);
                    this.Label2.Text = $"현재 대화: {this.ListBox.Items.Count}개";
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                e.SuppressKeyPress = true;

                string typed_msg = this.TextBox.Text.Trim();

                if (!string.IsNullOrWhiteSpace(typed_msg))
                {
                    string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {typed_msg}";
                    this.ListBox.Items.Add(typed_msg);
                    this.Label2.Text = $"현재 대화: {this.ListBox.Items.Count}개";
                    this.TextBox.Clear();
                    this.TextBox.Focus();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.ListBox.Items.Clear();
            MessageBox.Show("대화 기록이 모두 삭제되었습니다.");
        }
    }
}