using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Text.RegularExpressions; // Patterns check
using System.Data.SqlClient;

namespace BombuwalaRubberMills
{
    public partial class ManagerRegistration : Form
    {
        public ManagerRegistration()
        {
            InitializeComponent();
        }

        DatabaseConnection dc = new DatabaseConnection();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LoginInterface obj = new LoginInterface();
            obj.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {  
        }

        private void btn_register_Click(object sender, EventArgs e)
        {     
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            try
            {
                //  **validation**
                if (string.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "First name cannot be blank or include digits!";

                else if (string.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "Last name cannot be blank or include digits!";

                else if (!Regex.IsMatch(txt_nic.Text, @"^(?:19|20)?\d{2}(?:[0-35-8]\d\d(?<!(?:000|500|36[7-9]|3[7-9]\d|86[7-9]|8[7-9]\d)))[0]\d?\d{4}$")
                         && !Regex.IsMatch(txt_nic.Text, @"^\d{2}(?:[0-35-8]\d\d(?<!(?:000|500|36[7-9]|3[7-9]\d|86[7-9]|8[7-9]\d)))\d{4}(?:[vVxX])$"))
                    lbl_validation.Text = "Please enter a valid identity card number!";

                else if (string.IsNullOrEmpty(txt_mobileno.Text) || txt_mobileno.Text.Length != 10 || txt_mobileno.Text.Any(char.IsLetter))
                    lbl_validation.Text = "Please enter a valid mobile number!";

                else if (metroDateTime.Value.Date == DateTime.Now.Date)
                    lbl_validation.Text = "Please enter the date of birth!";

                else if (cmb_gender.SelectedIndex == -1)
                    lbl_validation.Text = "Please select gender!";

                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    lbl_validation.Text = "Type a valid e-mail address";

                else if (string.IsNullOrEmpty(txt_address.Text))
                    lbl_validation.Text = "Address cannot be empty!";

                else if (txt_password.Text.Length <= 6)
                    lbl_validation.Text = "Password must contain atleast 6 characters!";

                else if (txt_confpassword.Text != txt_password.Text)
                    lbl_validation.Text = "Password is different, check again!";

                //  **validation ends**
                else
                {
                    string q = "insert into Manager values('" + txt_nic.Text + "'," +
                                                        "'" + txt_fname.Text + "'," +
                                                        "'" + txt_lname.Text + "'," +
                                                        "'" + metroDateTime.Value + "'," +
                                                        "'" + cmb_gender.GetItemText(cmb_gender.SelectedItem) + "'," +
                                                        "'" + txt_email.Text + "'," +
                                                        "'" + txt_mobileno.Text + "'," +
                                                        "'" + txt_address.Text + "'," +
                                                        "'" + txt_password.Text + "')";
                    int i = dc.save_update_delete(q);

                    if (i == 1)
                    {
                        lbl_validation.Text = "";
                        MetroFramework.MetroMessageBox.Show(this, "Data saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MetroFramework.MetroMessageBox.Show(this, "Error occured while saving data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            metroDateTime.ResetText();
            cmb_gender.SelectedIndex = -1;
            txt_nic.Clear();
            txt_mobileno.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_password.Clear();
            txt_confpassword.Clear();
            lbl_validation.Text = "";
        }

        private void ManagerRegistration_Load(object sender, EventArgs e)
        {
            lbl_validation.Text = "";
        }
    }
}
