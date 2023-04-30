﻿using System;
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
    public partial class SupplierDatabaseView : Form
    {
        public SupplierDatabaseView()
        {
            InitializeComponent();
        }

        DatabaseConnection dc = new DatabaseConnection();

        public void loadData()
        {
            supplierDataGridView.DataSource = dc.display("select * from Supplier");
        }

        private void SupplierDatabaseView_Load(object sender, EventArgs e)
        {
            lbl_validation.Text = "";
            lbl_validation.ForeColor = System.Drawing.Color.Red;

            try
            {
                loadData();
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

        private void supplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sid.Text = supplierDataGridView.CurrentRow.Cells["SID"].Value.ToString();
            txt_fname.Text = supplierDataGridView.CurrentRow.Cells["First_Name"].Value.ToString();
            txt_lname.Text = supplierDataGridView.CurrentRow.Cells["Last_Name"].Value.ToString();
            txt_mobileno.Text = supplierDataGridView.CurrentRow.Cells["Telephone_Number"].Value.ToString();
            txt_email.Text = supplierDataGridView.CurrentRow.Cells["Email_Address"].Value.ToString();
            txt_address.Text = supplierDataGridView.CurrentRow.Cells["Address"].Value.ToString();

            lbl_validation.Text = "";
            lbl_validation.ForeColor = System.Drawing.Color.Red;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //  **validation**
                if (string.IsNullOrEmpty(txt_fname.Text) || txt_fname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "First name cannot be blank or include digits!";

                else if (string.IsNullOrEmpty(txt_lname.Text) || txt_lname.Text.Any(char.IsDigit))
                    lbl_validation.Text = "Last name cannot be blank or include digits!";

                else if (string.IsNullOrEmpty(txt_mobileno.Text) || txt_mobileno.Text.Length != 10)
                    lbl_validation.Text = "Please enter a valid mobile number!";

                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                    lbl_validation.Text = "Type a valid e-mail address";

                else if (string.IsNullOrEmpty(txt_address.Text))
                    lbl_validation.Text = "Address cannot be empty!";

                else
                {
                    int value = Convert.ToInt32(txt_sid.Text);
                    string query = "update Supplier set First_Name='" + txt_fname.Text + "' ," +
                                                       "Last_Name='" + txt_lname.Text + "' , " +
                                                       "Telephone_Number='" + txt_mobileno.Text + "' ," +
                                                       "Email_Address='" + txt_email.Text + "' ," +
                                                       "Address='" + txt_address.Text + "' where SID = '" + value + "' ";

                    int i = dc.save_update_delete(query);

                    if (i == 1)
                    {
                        lbl_validation.Text = "";
                        MetroFramework.MetroMessageBox.Show(this, "Data updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_sid.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mobileno.Clear();
            txt_email.Clear();
            txt_address.Clear();
            lbl_validation.Text = "";
        }
    }
}
