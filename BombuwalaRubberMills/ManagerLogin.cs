using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombuwalaRubberMills
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();

        }

        DatabaseConnection  dc = new DatabaseConnection();

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginInterface obj = new LoginInterface();
            obj.Show();
            this.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "Select count(1) from Manager Where NIC='" + txt_nic.Text + "'  AND Password='" + txt_password.Text + "' "; //sorting data with unicode

                int i = dc.searchData(query);

               
                if (i == 1)
                {
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
                }

                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Wrong credentials, Check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nic.Clear();
                    txt_password.Clear();
                }

            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Sql Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
