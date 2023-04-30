using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombuwalaRubberMills
{
    public partial class SupplierRegistration : Form
    {
        public SupplierRegistration()
        {
            InitializeComponent();
        }

        DatabaseConnection dc = new DatabaseConnection();

        public void loadData()
        {
            try
            {
                supplierDataGridView.DataSource = dc.display("select * from Supplier");
            }
            catch (SqlException)
            {
                MessageBox.Show("Databse Error, Cannot save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error encountered, Please restart the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mobileno.Clear();
            txt_email.Clear();
            txt_address.Clear();
            lbl_validation.Text = "";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                //  **validation**
                if (string.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "First name cannot be blank or include digits!";

                else if (string.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "Last name cannot be blank or include digits!";

                else if (string.IsNullOrEmpty(txt_mobileno.Text) || txt_mobileno.Text.Length != 10 || txt_mobileno.Text.Any(char.IsLetter))
                    lbl_validation.Text = "Please enter a valid mobile number!";

                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    lbl_validation.Text = "Type a valid e-mail address";

                else if (string.IsNullOrEmpty(txt_address.Text))
                    lbl_validation.Text = "Address cannot be empty!";

                else
                {
                    string q = "insert into Supplier (First_Name,Last_Name,Telephone_Number,Email_Address,Address) values('" + txt_fname.Text + "'," +
                                                           "'" + txt_lname.Text + "'," +
                                                           "'" + txt_mobileno.Text + "'," +
                                                           "'" + txt_email.Text + "'," +
                                                           "'" + txt_address.Text + "')";
                    int i = dc.save_update_delete(q);

                    if (i == 1)
                    {
                        lbl_validation.Text = "";
                        MetroFramework.MetroMessageBox.Show(this, "Data saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
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

        private void SupplierRegistration_Load(object sender, EventArgs e)
        {
            lbl_validation.Text = "";
            loadData();
        }
    }
}
