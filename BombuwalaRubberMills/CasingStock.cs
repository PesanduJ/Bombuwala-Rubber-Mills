using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombuwalaRubberMills
{
    public partial class CasingStock : Form
    {
        public CasingStock()
        {
            InitializeComponent();

            
            //disabling the text boxes
            if (txt_rTW.Text.Length == 0)
            {
                txt_coTW.Enabled = false;
                txt_uTW.Enabled = false;
            }

            if (txt_rPia.Text.Length == 0)
            {
                txt_coPia.Enabled = false;
                txt_uPia.Enabled = false;
            }

            if (txt_rScoo.Text.Length == 0)
            {
                txt_coScoo.Enabled = false;
                txt_uScoo.Enabled = false;
            }

            //shows brought forward values when the form loads
            showBroughtForwardValues();

        }

        DatabaseConnection dc = new DatabaseConnection();
        SQLiteConnection con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\data_table.db");

        //method declaration of clearing text box values
        public void clearAll()
        {
            txt_bfTW.Clear();
            txt_bfPia.Clear();
            txt_bfScoo.Clear();

            txt_rTW.Clear();
            txt_rPia.Clear();
            txt_rScoo.Clear();

            txt_coTW.Clear();
            txt_coPia.Clear();
            txt_coScoo.Clear();

            txt_uTW.Clear();
            txt_uPia.Clear();
            txt_uScoo.Clear();

            txt_tTW.Clear();
            txt_tPia.Clear();
            txt_tScoo.Clear();

            lbl_validation.Text = "";

        }

        //method to get three wheeler brought forward values from database
        public void broughtForwardValuesOfTW(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();

            SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_bfTW.Text = dr["Total"].ToString();  
                }

            con.Close(); 
        }

        //method to get piaggio brought forward values from database
        public void broughtForwardValuesOfPia(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();

            SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_bfPia.Text = dr["Total"].ToString();
                }

            con.Close();
        }

        //method to get scooter brought forward values from database
        public void broughtForwardValuesOfScoo(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();

            SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_bfScoo.Text = dr["Total"].ToString();
                }

            con.Close();
        }

        //method to show brought forward values
        public void showBroughtForwardValues()
        {
            var yesterday = bfDate.Value.AddDays(-1);

            string query1 = "select Total from Casing_Stock where CName ='Three Wheeler' AND Date = '" + yesterday + "'";
            string query2 = "select Total from Casing_Stock where CName ='Piaggio' AND Date = '" + yesterday + "'";
            string query3 = "select Total from Casing_Stock where CName ='Scooter' AND Date = '" + yesterday + "'";

            broughtForwardValuesOfTW(query1);
            broughtForwardValuesOfPia(query2);
            broughtForwardValuesOfScoo(query3);
        }
        
        

        private void btn_addup_Click(object sender, EventArgs e)
        {
            try
            {
                //  **validation**

                if (string.IsNullOrEmpty(txt_bfTW.Text) || string.IsNullOrEmpty(txt_bfPia.Text) || string.IsNullOrEmpty(txt_bfScoo.Text) ||
                         string.IsNullOrEmpty(txt_rTW.Text) || string.IsNullOrEmpty(txt_rPia.Text) || string.IsNullOrEmpty(txt_rScoo.Text) ||
                         string.IsNullOrEmpty(txt_coTW.Text) || string.IsNullOrEmpty(txt_coPia.Text) || string.IsNullOrEmpty(txt_coScoo.Text) ||
                         string.IsNullOrEmpty(txt_uTW.Text) || string.IsNullOrEmpty(txt_uPia.Text) || string.IsNullOrEmpty(txt_uScoo.Text))
                    lbl_validation.Text = "Please fill all spaces!";

                else if (txt_bfTW.Text.Any(char.IsLetter) || txt_bfPia.Text.Any(char.IsLetter) || txt_bfScoo.Text.Any(char.IsLetter) ||
                         txt_rTW.Text.Any(char.IsLetter) || txt_rPia.Text.Any(char.IsLetter) || txt_rScoo.Text.Any(char.IsLetter) ||
                         txt_coTW.Text.Any(char.IsLetter) || txt_coPia.Text.Any(char.IsLetter) || txt_coScoo.Text.Any(char.IsLetter) ||
                         txt_uTW.Text.Any(char.IsLetter) || txt_uPia.Text.Any(char.IsLetter) || txt_uScoo.Text.Any(char.IsLetter))
                    lbl_validation.Text = "Please enter only numbers!";

                else
                {
                    
                    string TW = "insert into Casing_Stock values ('" + bfDate.Value + "','Three Wheeler'," +
                                "'" + txt_bfTW.Text + "'," +
                                "'" + txt_rTW.Text + "'," +
                                "'" + txt_coTW.Text + "'," +
                                "'" + txt_uTW.Text + "'," +
                                "'" + txt_tTW.Text + "')";

                    string Pia = "insert into Casing_Stock values ('" + bfDate.Value + "','Piaggio'," +
                                "'" + txt_bfPia.Text + "'," +
                                "'" + txt_rPia.Text + "'," +
                                "'" + txt_coPia.Text + "'," +
                                "'" + txt_uPia.Text + "'," +
                                "'" + txt_tPia.Text + "')";

                    string Scoo = "insert into Casing_Stock values ('" + bfDate.Value + "','Scooter'," +
                                "'" + txt_bfScoo.Text + "'," +
                                "'" + txt_rScoo.Text + "'," +
                                "'" + txt_coScoo.Text + "'," +
                                "'" + txt_uScoo.Text + "'," +
                                "'" + txt_tScoo.Text + "')";

                    int a = dc.save_update_delete(TW);
                    int b = dc.save_update_delete(Pia);
                    int c = dc.save_update_delete(Scoo);

                    int h = a + b + c;

                    if (h == 3)
                    {
                        lbl_validation.Text = "";
                        MetroFramework.MetroMessageBox.Show(this, "Data saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll();
                        showBroughtForwardValues();
                    }

                    else
                        MetroFramework.MetroMessageBox.Show(this, "Error occured while saving data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (SQLiteException ex)
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
            clearAll();
        }

        private void txt_bfTW_TextChanged(object sender, EventArgs e)
        {  
        }

        private void txt_bfPia_TextChanged(object sender, EventArgs e)
        {   
        }

        private void txt_rTW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rTW.Text))
                txt_coTW.Enabled = true;
        }

        private void txt_rPia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rPia.Text))
                txt_coPia.Enabled = true;
        }

        private void txt_rScoo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rScoo.Text))
                txt_coScoo.Enabled = true;
        }

        private void txt_coTW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rTW.Text) || !string.IsNullOrEmpty(txt_coTW.Text))
                txt_uTW.Enabled = true;
        }

        private void txt_coPia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rPia.Text) || !string.IsNullOrEmpty(txt_coPia.Text))
                txt_uPia.Enabled = true;
        }

        private void txt_coScoo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_rScoo.Text) || !string.IsNullOrEmpty(txt_coScoo.Text))
                txt_uScoo.Enabled = true;
        }

        private void txt_uTW_TextChanged(object sender, EventArgs e)
        {
            if (txt_rTW.Text.Any(char.IsLetter) || txt_coTW.Text.Any(char.IsLetter) || txt_uTW.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_rTW.Text) || !string.IsNullOrEmpty(txt_coTW.Text) || !string.IsNullOrEmpty(txt_uTW.Text))
            {
                int bfTW = Convert.ToInt32(txt_bfTW.Text);
                int rTW = Convert.ToInt32(txt_rTW.Text);
                int coTW = Convert.ToInt32(txt_coTW.Text);
                int uTW = Convert.ToInt32(txt_uTW.Text);

                int tTW = (bfTW + rTW) - (coTW + uTW);
                txt_tTW.Text = tTW.ToString();
            }

            else
                txt_uTW.Enabled = false;
        }

        private void txt_uPia_TextChanged(object sender, EventArgs e)
        {
            if (txt_rPia.Text.Any(char.IsLetter) || txt_coPia.Text.Any(char.IsLetter) || txt_uPia.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_rPia.Text) || !string.IsNullOrEmpty(txt_coPia.Text) || !string.IsNullOrEmpty(txt_uPia.Text))
            {
                int bfPia = Convert.ToInt32(txt_bfPia.Text);
                int rPia = Convert.ToInt32(txt_rPia.Text);
                int coPia = Convert.ToInt32(txt_coPia.Text);
                int uPia = Convert.ToInt32(txt_uPia.Text);

                int tPia = (bfPia + rPia) - (coPia + uPia);
                txt_tPia.Text = tPia.ToString();
            }

            else
                txt_uPia.Enabled = false;
        }

        private void txt_uScoo_TextChanged(object sender, EventArgs e)
        {
            if (txt_rScoo.Text.Any(char.IsLetter) || txt_coScoo.Text.Any(char.IsLetter) || txt_uScoo.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }
            else if (!string.IsNullOrEmpty(txt_rScoo.Text) || !string.IsNullOrEmpty(txt_coScoo.Text) || !string.IsNullOrEmpty(txt_uScoo.Text))
            {
                int bfScoo = Convert.ToInt32(txt_bfScoo.Text);
                int rScoo = Convert.ToInt32(txt_rScoo.Text);
                int coScoo = Convert.ToInt32(txt_coScoo.Text);
                int uScoo = Convert.ToInt32(txt_uScoo.Text);

                int tScoo = (bfScoo + rScoo) - (coScoo + uScoo);
                txt_tScoo.Text = tScoo.ToString();
            }

            else
                txt_uScoo.Enabled = false;
        }

        private void bfDate_ValueChanged(object sender, EventArgs e)
        { 
        }

        private void getBFValuesOfPrevDays_ValueChanged(object sender, EventArgs e)
        {
            string dateSelected = getBFValuesOfPrevDays.Value.ToString();
            string query1 = "select Total from Casing_Stock where CName ='Three Wheeler' AND Date = '" + dateSelected + "'";
            string query2 = "select Total from Casing_Stock where CName ='Piaggio' AND Date = '" + dateSelected + "'";
            string query3 = "select Total from Casing_Stock where CName ='Scooter' AND Date = '" + dateSelected + "'";

            broughtForwardValuesOfTW(query1);
            broughtForwardValuesOfPia(query2);
            broughtForwardValuesOfScoo(query3);
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {     
        }

        private void cb_dateActive_Click(object sender, EventArgs e)
        {
            if(cb_dateActive.Checked)
                bfDate.Enabled = true;

            else
                bfDate.Enabled = false;
            
        }

        private void CasingStock_Load(object sender, EventArgs e)
        {
            getBFValuesOfPrevDays.Value = DateTime.Now.AddDays(-1);

            lbl_validation.Text = "";
            lbl_validation.ForeColor = System.Drawing.Color.Red;
        }
    }
}
