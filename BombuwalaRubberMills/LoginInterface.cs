using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;    //material skin

namespace BombuwalaRubberMills
{
    public partial class LoginInterface : Form

    {
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {  
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_testconnection_Click(object sender, EventArgs e)
        {
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            ManagerLogin obj = new ManagerLogin();
            obj.Show();
            this.Hide();
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            ManagerRegistration obj = new ManagerRegistration();
            obj.Show();
            this.Hide();
        }
    }
}
