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
    public partial class BuffingDust : Form
    {
        public BuffingDust()
        {
            InitializeComponent();
            
            if(txt_p30.Text.Length == 0)
                txt_d30.Enabled = false;

            if (txt_p20.Text.Length == 0)
                txt_d20.Enabled = false;

            if (txt_p12.Text.Length == 0)
                txt_d12.Enabled = false;

            if (txt_p10.Text.Length == 0)
                txt_d10.Enabled = false;

            if (txt_pDSI.Text.Length == 0)
                txt_dDSI.Enabled = false;

            if (txt_pWR.Text.Length == 0)
                txt_dWR.Enabled = false;

        }

        DatabaseConnection dc = new DatabaseConnection();

        public void clearAll()
        {
            txt_unitprice30.Clear();
            productionDate.ResetText();

            txt_p10.Clear();
            txt_p12.Clear();
            txt_p20.Clear();
            txt_p30.Clear();
            txt_pDSI.Clear();
            txt_pWR.Clear();

            txt_d10.Clear();
            txt_d10.Enabled = false;
            txt_d12.Clear();
            txt_d12.Enabled = false;
            txt_d20.Clear();
            txt_d20.Enabled = false;
            txt_d30.Clear();
            txt_d30.Enabled = false;
            txt_dDSI.Clear();
            txt_dDSI.Enabled = false;
            txt_dWR.Clear();
            txt_dWR.Enabled = false;

            txt_r10.Clear();
            txt_r12.Clear();
            txt_r20.Clear();
            txt_r30.Clear();
            txt_rDSI.Clear();
            txt_rWR.Clear();

            txt_unitprice10.Clear();
            txt_unitprice12.Clear();
            txt_unitprice20.Clear();
            txt_unitprice30.Clear();
            txt_unitpriceDSI.Clear();
            txt_unitpriceWR.Clear();

            lbl_validation.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txt_d30_TextChanged(object sender, EventArgs e)
        {
            if (txt_p30.Text.Any(char.IsLetter) || txt_d30.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_p30.Text) || !string.IsNullOrEmpty(txt_d30.Text))
            {
                int p30 = Convert.ToInt32(txt_p30.Text);
                int d30 = Convert.ToInt32(txt_d30.Text);
                int r30 = p30 - d30;
                txt_r30.Text = r30.ToString();
            }

            else
                txt_d30.Enabled = false;
        }

        private void txt_p30_TextChanged(object sender, EventArgs e)
        {
            if (txt_p30.Text.Length > 0)
                txt_d30.Enabled = true;
        }

        private void txt_d20_TextChanged(object sender, EventArgs e)
        {
            if (txt_p20.Text.Any(char.IsLetter) || txt_d20.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_p20.Text) || !string.IsNullOrEmpty(txt_d20.Text))
            {
                int p20 = Convert.ToInt32(txt_p20.Text);
                int d20 = Convert.ToInt32(txt_d20.Text);
                int r20 = p20 - d20;
                txt_r20.Text = r20.ToString();
            }

            else
                txt_d20.Enabled = false;
        }

        private void txt_d12_TextChanged(object sender, EventArgs e)
        {
            if (txt_p12.Text.Any(char.IsLetter) || txt_d12.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_p12.Text) || !string.IsNullOrEmpty(txt_d12.Text))
            {
                int p12 = Convert.ToInt32(txt_p12.Text);
                int d12 = Convert.ToInt32(txt_d12.Text);
                int r12 = p12 - d12;
                txt_r12.Text = r12.ToString();
            }

            else
                txt_d12.Enabled = false;
        }

        private void txt_p20_TextChanged(object sender, EventArgs e)
        {
            if (txt_p20.Text.Length > 0)
                txt_d20.Enabled = true;
        }

        private void txt_p12_TextChanged(object sender, EventArgs e)
        {
            if (txt_p12.Text.Length > 0)
                txt_d12.Enabled = true;
        }

        private void txt_d10_TextChanged(object sender, EventArgs e)
        {
            if (txt_p10.Text.Any(char.IsLetter) || txt_d10.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_p10.Text) || !string.IsNullOrEmpty(txt_d10.Text))
            {
                int p10 = Convert.ToInt32(txt_p10.Text);
                int d10 = Convert.ToInt32(txt_d10.Text);
                int r10 = p10 - d10;
                txt_r10.Text = r10.ToString();
            }

            else
                txt_d10.Enabled = false;
        }

        private void txt_p10_TextChanged(object sender, EventArgs e)
        {
            if (txt_p10.Text.Length > 0)
                txt_d10.Enabled = true;
        }

        private void txt_dDSI_TextChanged(object sender, EventArgs e)
        {
            if (txt_pDSI.Text.Any(char.IsLetter) || txt_dDSI.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_pDSI.Text) || !string.IsNullOrEmpty(txt_dDSI.Text))
            {
                int pDSI = Convert.ToInt32(txt_pDSI.Text);
                int dDSI = Convert.ToInt32(txt_dDSI.Text);
                int rDSI = pDSI - dDSI;
                txt_rDSI.Text = rDSI.ToString();
            }

            else
                txt_dDSI.Enabled = false;
        }

        private void txt_pDSI_TextChanged(object sender, EventArgs e)
        {
            if (txt_pDSI.Text.Length > 0)
                txt_dDSI.Enabled = true;
        }

        private void txt_dWR_TextChanged(object sender, EventArgs e)
        {
            if (txt_pWR.Text.Any(char.IsLetter) || txt_dWR.Text.Any(char.IsLetter))
            {
                MessageBox.Show(this, "Input should be digits!");
            }

            else if (!string.IsNullOrEmpty(txt_pWR.Text) || !string.IsNullOrEmpty(txt_dWR.Text))
            {
                int pWR = Convert.ToInt32(txt_pWR.Text);
                int dWR = Convert.ToInt32(txt_dWR.Text);
                int rWR = pWR - dWR;
                txt_rWR.Text = rWR.ToString();
            }

            else
                txt_dWR.Enabled = false;
        }

        private void txt_pWR_TextChanged(object sender, EventArgs e)
        {
            if (txt_pWR.Text.Length > 0)
                txt_dWR.Enabled = true;
        }

        private void btn_addup_Click(object sender, EventArgs e)
        {
            //  **validation**

            if (string.IsNullOrEmpty(txt_p30.Text) || string.IsNullOrEmpty(txt_p20.Text) || string.IsNullOrEmpty(txt_p12.Text) || string.IsNullOrEmpty(txt_p10.Text) || string.IsNullOrEmpty(txt_pDSI.Text) || string.IsNullOrEmpty(txt_pWR.Text) ||
                     string.IsNullOrEmpty(txt_d10.Text) || string.IsNullOrEmpty(txt_d20.Text) || string.IsNullOrEmpty(txt_d12.Text) || string.IsNullOrEmpty(txt_d10.Text) || string.IsNullOrEmpty(txt_dDSI.Text) || string.IsNullOrEmpty(txt_dWR.Text) ||
                     string.IsNullOrEmpty(txt_r10.Text) || string.IsNullOrEmpty(txt_r20.Text) || string.IsNullOrEmpty(txt_r12.Text) || string.IsNullOrEmpty(txt_r10.Text) || string.IsNullOrEmpty(txt_rDSI.Text) || string.IsNullOrEmpty(txt_rWR.Text))
                lbl_validation.Text = "Please fill all spaces!";

            else if (txt_p30.Text.Any(char.IsLetter) || txt_p20.Text.Any(char.IsLetter) || txt_p12.Text.Any(char.IsLetter) || txt_p10.Text.Any(char.IsLetter) || txt_pDSI.Text.Any(char.IsLetter) || txt_pWR.Text.Any(char.IsLetter) ||
                     txt_d10.Text.Any(char.IsLetter) || txt_d20.Text.Any(char.IsLetter) || txt_d12.Text.Any(char.IsLetter) || txt_d10.Text.Any(char.IsLetter) || txt_dDSI.Text.Any(char.IsLetter) || txt_dWR.Text.Any(char.IsLetter) ||
                     txt_r10.Text.Any(char.IsLetter) || txt_r20.Text.Any(char.IsLetter) || txt_r12.Text.Any(char.IsLetter) || txt_r10.Text.Any(char.IsLetter) || txt_rDSI.Text.Any(char.IsLetter) || txt_rWR.Text.Any(char.IsLetter))
                lbl_validation.Text = "Please enter only numbers!";

            else if(string.IsNullOrEmpty(txt_unitprice30.Text) || string.IsNullOrEmpty(txt_unitprice20.Text) || string.IsNullOrEmpty(txt_unitprice12.Text) ||
                    string.IsNullOrEmpty(txt_unitprice10.Text) || string.IsNullOrEmpty(txt_unitpriceDSI.Text) || string.IsNullOrEmpty(txt_unitpriceWR.Text))
                lbl_validation.Text = "Please enter all unit prices!";

            else
            {
                try
                {
                    float uprice30 = float.Parse(txt_unitprice30.Text);
                    float uprice20 = float.Parse(txt_unitprice20.Text);
                    float uprice12 = float.Parse(txt_unitprice12.Text);
                    float uprice10 = float.Parse(txt_unitprice10.Text);
                    float upriceDSI = float.Parse(txt_unitpriceDSI.Text);
                    float upriceWR = float.Parse(txt_unitpriceWR.Text);

                    uprice30 = uprice30 * int.Parse(txt_r30.Text);
                    uprice20 = uprice20 * int.Parse(txt_r20.Text);
                    uprice12 = uprice12 * int.Parse(txt_r12.Text);
                    uprice10 = uprice10 * int.Parse(txt_r10.Text);
                    upriceDSI = upriceDSI * int.Parse(txt_rDSI.Text);
                    upriceWR = upriceWR * int.Parse(txt_rWR.Text);


                    string mesh30 = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','30 Mesh','" + uprice30 + "'," +
                                    "'" + txt_p30.Text + "'," +
                                    "'" + txt_d30.Text + "'," +
                                    "'" + txt_r30.Text + "')";

                    string mesh20 = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','20 Mesh','" + uprice20 + "'," +
                                    "'" + txt_p20.Text + "'," +
                                    "'" + txt_d20.Text + "'," +
                                    "'" + txt_r20.Text + "')";

                    string mesh12 = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','12 Mesh','" + uprice12 + "'," +
                                    "'" + txt_p12.Text + "'," +
                                    "'" + txt_d12.Text + "'," +
                                    "'" + txt_r12.Text + "')";

                    string mesh10 = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','10 Mesh','" + uprice10 + "'," +
                                    "'" + txt_p10.Text + "'," +
                                    "'" + txt_d10.Text + "'," +
                                    "'" + txt_r10.Text + "')";

                    string DSI = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','DSI','" + upriceDSI + "'," +
                                    "'" + txt_pDSI.Text + "'," +
                                    "'" + txt_dDSI.Text + "'," +
                                    "'" + txt_rDSI.Text + "')";

                    string WR = "insert into Buffing_Dust(Date,BName,BPrice,Production,Dispatch,Remaining) " +
                                    "values('" + productionDate.Value + "','White Rubber','" + upriceWR + "'," +
                                    "'" + txt_pWR.Text + "'," +
                                    "'" + txt_dWR.Text + "'," +
                                    "'" + txt_rWR.Text + "')";

                    int a = dc.save_update_delete(mesh30);
                    int b = dc.save_update_delete(mesh20);
                    int c = dc.save_update_delete(mesh12);
                    int d = dc.save_update_delete(mesh10);
                    int f = dc.save_update_delete(DSI);
                    int g = dc.save_update_delete(WR);

                    int h = a + b + c + d + f + g;

                    if (h == 6)
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

        private void BuffingDust_Load(object sender, EventArgs e)
        {
            lbl_validation.Text = "";
            lbl_validation.ForeColor = System.Drawing.Color.Red;
        }

        private void cb_dateActive_Click(object sender, EventArgs e)
        {
            if (cb_dateActive.Checked)
                productionDate.Enabled = true;

            else
                productionDate.Enabled = false;
        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel20_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
