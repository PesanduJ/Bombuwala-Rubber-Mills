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
    public partial class TyreProduction : Form
    {
        public TyreProduction()
        {
            InitializeComponent();

            if (txt_pTW.Text.Length == 0)
            {
                txt_dTW.Enabled = false;
                txt_rTW.Enabled = false;
            }

            if (txt_pPia.Text.Length == 0)
            {
                txt_dPia.Enabled = false;
                txt_rPia.Enabled = false;
            }

            if (txt_pScoo.Text.Length == 0)
            {
                txt_dScoo.Enabled = false;
                txt_rScoo.Enabled = false;
            }

        }

        DatabaseConnection dc = new DatabaseConnection();

        public void clearAll()
        {
            txt_pTW.Clear();
            txt_pPia.Clear();
            txt_pScoo.Clear();

            txt_dTW.Clear();
            txt_dPia.Clear();   
            txt_dScoo.Clear();

            txt_rTW.Clear();
            txt_rPia.Clear();
            txt_rScoo.Clear();

            txt_bTW.Clear();
            txt_bPia.Clear();
            txt_bScoo.Clear();
            txt_bTot.Clear();

            txt_unitpriceTW.Clear();
            txt_unitpricePia.Clear();
            txt_unitpriceScoo.Clear();

            lbl_validation.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txt_dTW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pTW.Text) || !string.IsNullOrEmpty(txt_dTW.Text))
                txt_rTW.Enabled = true;
        }

        private void txt_dPia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pPia.Text) || !string.IsNullOrEmpty(txt_dPia.Text))
                txt_rPia.Enabled = true;
        }

        private void txt_dScoo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pScoo.Text) || !string.IsNullOrEmpty(txt_dScoo.Text))
                txt_rScoo.Enabled = true;
        }

        private void txt_pTW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pTW.Text))
                txt_dTW.Enabled = true;
        }

        private void txt_pPia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pPia.Text))
                txt_dPia.Enabled = true;
        }

        private void txt_pScoo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_pScoo.Text))
                txt_dScoo.Enabled = true;
        }

        private void txt_rTW_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_pTW.Text.Any(char.IsLetter) || txt_dTW.Text.Any(char.IsLetter) || txt_rTW.Text.Any(char.IsLetter))
                {
                    MessageBox.Show(this, "Input should be digits!");
                }

                else if (!string.IsNullOrEmpty(txt_pTW.Text) || !string.IsNullOrEmpty(txt_dTW.Text) || !string.IsNullOrEmpty(txt_rTW.Text))
                {
                    int pTW = Convert.ToInt32(txt_pTW.Text);
                    int dTW = Convert.ToInt32(txt_dTW.Text);
                    int rTW = Convert.ToInt32(txt_rTW.Text);
                    int bTW = pTW - (dTW + rTW);
                    txt_bTW.Text = bTW.ToString();
                }

                else
                    txt_rTW.Enabled = false;
            }
            
            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid Format!");
            }

        }

        private void txt_rPia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_pPia.Text.Any(char.IsLetter) || txt_dPia.Text.Any(char.IsLetter) || txt_rPia.Text.Any(char.IsLetter))
                {
                    MessageBox.Show(this, "Input should be digits!");
                }

                else if (!string.IsNullOrEmpty(txt_pPia.Text) || !string.IsNullOrEmpty(txt_dPia.Text) || !string.IsNullOrEmpty(txt_rPia.Text))
                {
                    int pPia = Convert.ToInt32(txt_pPia.Text);
                    int dPia = Convert.ToInt32(txt_dPia.Text);
                    int rPia = Convert.ToInt32(txt_rPia.Text);
                    int bPia = pPia - (dPia + rPia);
                    txt_bPia.Text = bPia.ToString();
                }

                else
                    txt_rPia.Enabled = false;
            }

            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid Format!");
            }
            
        }

        private void txt_rScoo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_pScoo.Text.Any(char.IsLetter) || txt_dScoo.Text.Any(char.IsLetter) || txt_rScoo.Text.Any(char.IsLetter))
                {
                    MessageBox.Show(this, "Input should be digits!");
                }

                else if (!string.IsNullOrEmpty(txt_pScoo.Text) || !string.IsNullOrEmpty(txt_dScoo.Text) || !string.IsNullOrEmpty(txt_rScoo.Text))
                {
                    int pScoo = Convert.ToInt32(txt_pScoo.Text);
                    int dScoo = Convert.ToInt32(txt_dScoo.Text);
                    int rScoo = Convert.ToInt32(txt_rScoo.Text);
                    int bScoo = pScoo - (dScoo + rScoo);
                    txt_bScoo.Text = bScoo.ToString();

                    int bTW = Convert.ToInt32(txt_bTW.Text);
                    int bPia = Convert.ToInt32(txt_bPia.Text);
                    int bTot = bTW + bPia + bScoo;
                    txt_bTot.Text = bTot.ToString();
                }

                else
                    txt_rScoo.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid Format!");
            }
            
        }

        private void btn_addup_Click(object sender, EventArgs e)
        {
            //  **validation**

            if(string.IsNullOrEmpty(txt_pTW.Text) || string.IsNullOrEmpty(txt_pPia.Text) || string.IsNullOrEmpty(txt_pScoo.Text) ||
                    string.IsNullOrEmpty(txt_dTW.Text) || string.IsNullOrEmpty(txt_dPia.Text) || string.IsNullOrEmpty(txt_dScoo.Text) ||
                    string.IsNullOrEmpty(txt_rTW.Text) || string.IsNullOrEmpty(txt_rPia.Text) || string.IsNullOrEmpty(txt_rScoo.Text))
                lbl_validation.Text = "Please fill all spaces!";
    
            else if (txt_pTW.Text.Any(char.IsLetter) || txt_pPia.Text.Any(char.IsLetter) || txt_pScoo.Text.Any(char.IsLetter) ||
                     txt_dTW.Text.Any(char.IsLetter) || txt_dPia.Text.Any(char.IsLetter) || txt_dScoo.Text.Any(char.IsLetter) ||
                     txt_rTW.Text.Any(char.IsLetter) || txt_rPia.Text.Any(char.IsLetter) || txt_rScoo.Text.Any(char.IsLetter))
                lbl_validation.Text = "Please enter only numbers!";

            else if (string.IsNullOrEmpty(txt_unitpriceTW.Text) || string.IsNullOrEmpty(txt_unitpricePia.Text) || string.IsNullOrEmpty(txt_unitpriceScoo.Text))
                lbl_validation.Text = "Please enter all unit prices!";

            else
            {
                try
                {
                    float upriceTW = float.Parse(txt_unitpriceTW.Text);
                    float upricePia = float.Parse(txt_unitpricePia.Text);
                    float upriceScoo = float.Parse(txt_unitpriceScoo.Text);

                    upriceTW = upriceTW * int.Parse(txt_bTW.Text);
                    upricePia = upricePia * int.Parse(txt_bPia.Text);
                    upriceScoo = upriceScoo * int.Parse(txt_bScoo.Text);

                    string TW = "insert into Tyre_Production(Date,TName,TPrice,Production,Dispatch,Rejected,Balance) " +
                                "values('" + productionDate.Value + "','Three Wheeler','" + upriceTW + "','" + txt_pTW.Text + "'," +
                                "'" + txt_dTW.Text + "'," +
                                "'" + txt_rTW.Text + "'," +
                                "'" + txt_bTW.Text + "')";

                    string Pia = "insert into Tyre_Production(Date,TName,TPrice,Production,Dispatch,Rejected,Balance) " +
                                "values('" + productionDate.Value + "','Piaggio','" + upricePia + "','" + txt_pPia.Text + "'," +
                                "'" + txt_dPia.Text + "'," +
                                "'" + txt_rPia.Text + "'," +
                                "'" + txt_bPia.Text + "')";

                    string Scoo = "insert into Tyre_Production(Date,TName,TPrice,Production,Dispatch,Rejected,Balance,Total) " +
                                "values('" + productionDate.Value + "','Scooter','" + upriceScoo + "','" + txt_pScoo.Text + "'," +
                                "'" + txt_dScoo.Text + "'," +
                                "'" + txt_rScoo.Text + "'," +
                                "'" + txt_bScoo.Text + "'," +
                                "'" + txt_bTot.Text + "')";

                    int a = dc.save_update_delete(TW);
                    int b = dc.save_update_delete(Pia);
                    int c = dc.save_update_delete(Scoo);

                    int h = a + b + c;

                    if (h == 3)
                    {
                        lbl_validation.Text = "";
                        MetroFramework.MetroMessageBox.Show(this, "Data saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll();
                    }

                    else
                        MetroFramework.MetroMessageBox.Show(this, "Error occured while saving data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cb_dateActive_Click(object sender, EventArgs e)
        {
            if (cb_dateActive.Checked)
                productionDate.Enabled = true;

            else
                productionDate.Enabled = false;
        }

        private void TyreProduction_Load(object sender, EventArgs e)
        {
            lbl_validation.Text = "";
            lbl_validation.ForeColor = System.Drawing.Color.Red;
        }
    }
}
