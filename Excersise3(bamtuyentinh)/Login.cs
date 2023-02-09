using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersise3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        string account = "admin".Trim();
        string password = "admin123".Trim();
        string output = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng, Vui Lòng Nhập Lại";
        private void login_button_Click(object sender, EventArgs e)
        {
            
            string x = account_textbox.Text.Trim();
            string y = password_textBox.Text.Trim();
            if (String.Compare(account,x)==0&& String.Compare(password,y)==0)
            {
                Admin c = new Admin();
                c.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(output, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        int check = 1;
        private void Hide_Password_button_Click(object sender, EventArgs e)
        {
            if (check== 1)
            {
                password_textBox.UseSystemPasswordChar = false;
                Hide_Password_button.Text = "Hide Password";
                check = 0;
            }
            else
            {
                password_textBox.UseSystemPasswordChar = true;
                Hide_Password_button.Text = "Show Password";
                check = 1;
            }
        }
        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
