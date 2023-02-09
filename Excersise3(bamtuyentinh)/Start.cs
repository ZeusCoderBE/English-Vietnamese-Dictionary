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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Sound_button_Click(null, null);
        }

        private void User_button_Click(object sender, EventArgs e)
        {
            User a = new User();
            a.Show(); 
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Login b = new Login();
            b.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }
        int checkSound = 1;
        playSound ps = new playSound();
        private void Sound_button_Click(object sender, EventArgs e)
        {
            if (checkSound == 1)
            {
                ps.OpenMediaFile("tetdong.mp3");//ten bai hat.đinh dangcbai hat(bai hat phai di kem voi file exe)
                ps.PlayMediaFile(true);

                Sound_button.Text = "Sound Off ";
                checkSound = 0;
            }
            else
            {
                ps.ClosePlayer();
                Sound_button.Text = "Sound On";
                checkSound = 1;
            }
        }
    }
}
