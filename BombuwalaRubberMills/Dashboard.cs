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

namespace BombuwalaRubberMills
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
            DatabaseConnection dc = new DatabaseConnection();
        }

        public  void customizeDesign()
        {
            managePanel.Visible = false;
            registerPanel.Visible = false;
            databasePanel.Visible = false;
            reportsPanel.Visible = false;

        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            managePanel.Visible = true;
            registerPanel.Visible = false;
            databasePanel.Visible = false;
            reportsPanel.Visible = false;

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            managePanel.Visible = false;
            registerPanel.Visible = true;
            databasePanel.Visible = false;
            reportsPanel.Visible = false;
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            managePanel.Visible = false;
            registerPanel.Visible = false;
            databasePanel.Visible = true;
            reportsPanel.Visible = false;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            managePanel.Visible = false;
            registerPanel.Visible = false;
            databasePanel.Visible = false;
            reportsPanel.Visible = true;
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            CustomerRegistration obj = new CustomerRegistration();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            SupplierRegistration obj = new SupplierRegistration();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_buffingdust_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            BuffingDust obj = new BuffingDust();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_tyreproduction_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            TyreProduction obj = new TyreProduction();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_casingstock_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            CasingStock obj = new CasingStock();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_cusDatabase_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            CustomerDatabaseView obj = new CustomerDatabaseView();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_supDatabase_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            SupplierDatabaseView obj = new SupplierDatabaseView();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_invDatabase_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            InventoryDatabaseView obj = new InventoryDatabaseView();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ManagerLogin obj = new ManagerLogin();
            obj.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_dsReport_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            DailyReport obj = new DailyReport();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_wsReport_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            WeeklyReport obj = new WeeklyReport();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            managePanel.Visible = false;
            registerPanel.Visible = false;
            databasePanel.Visible = false;
            reportsPanel.Visible = false;

            displayPanel.Controls.Clear();
            Email obj = new Email();
            obj.TopLevel = false;
            obj.AutoScroll = true;
            displayPanel.Controls.Add(obj);
            obj.Show();

            obj.WindowState = FormWindowState.Maximized;
        }
    }
}
