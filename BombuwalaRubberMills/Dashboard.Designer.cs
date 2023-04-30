namespace BombuwalaRubberMills
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.btn_wsReport = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dsReport = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reports = new Guna.UI2.WinForms.Guna2Button();
            this.databasePanel = new System.Windows.Forms.Panel();
            this.btn_invDatabase = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supDatabase = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cusDatabase = new Guna.UI2.WinForms.Guna2Button();
            this.btn_database = new Guna.UI2.WinForms.Guna2Button();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.btn_supplier = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.managePanel = new System.Windows.Forms.Panel();
            this.btn_casingstock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tyreproduction = new Guna.UI2.WinForms.Guna2Button();
            this.btn_buffingdust = new Guna.UI2.WinForms.Guna2Button();
            this.btn_manage = new Guna.UI2.WinForms.Guna2Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_email = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel.SuspendLayout();
            this.reportsPanel.SuspendLayout();
            this.databasePanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.managePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.menuPanel.Controls.Add(this.btn_email);
            this.menuPanel.Controls.Add(this.reportsPanel);
            this.menuPanel.Controls.Add(this.btn_logout);
            this.menuPanel.Controls.Add(this.btn_exit);
            this.menuPanel.Controls.Add(this.btn_reports);
            this.menuPanel.Controls.Add(this.databasePanel);
            this.menuPanel.Controls.Add(this.btn_database);
            this.menuPanel.Controls.Add(this.registerPanel);
            this.menuPanel.Controls.Add(this.btn_register);
            this.menuPanel.Controls.Add(this.managePanel);
            this.menuPanel.Controls.Add(this.btn_manage);
            this.menuPanel.Location = new System.Drawing.Point(0, 26);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(184, 748);
            this.menuPanel.TabIndex = 0;
            // 
            // reportsPanel
            // 
            this.reportsPanel.BackColor = System.Drawing.Color.White;
            this.reportsPanel.Controls.Add(this.btn_wsReport);
            this.reportsPanel.Controls.Add(this.btn_dsReport);
            this.reportsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsPanel.Location = new System.Drawing.Point(0, 532);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(184, 100);
            this.reportsPanel.TabIndex = 9;
            // 
            // btn_wsReport
            // 
            this.btn_wsReport.Animated = true;
            this.btn_wsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_wsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_wsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_wsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_wsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_wsReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_wsReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_wsReport.ForeColor = System.Drawing.Color.White;
            this.btn_wsReport.Location = new System.Drawing.Point(0, 31);
            this.btn_wsReport.Name = "btn_wsReport";
            this.btn_wsReport.Size = new System.Drawing.Size(184, 31);
            this.btn_wsReport.TabIndex = 2;
            this.btn_wsReport.Text = "Weekly Sales Report";
            this.btn_wsReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_wsReport.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_wsReport.Click += new System.EventHandler(this.btn_wsReport_Click);
            // 
            // btn_dsReport
            // 
            this.btn_dsReport.Animated = true;
            this.btn_dsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_dsReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dsReport.ForeColor = System.Drawing.Color.White;
            this.btn_dsReport.Location = new System.Drawing.Point(0, 0);
            this.btn_dsReport.Name = "btn_dsReport";
            this.btn_dsReport.Size = new System.Drawing.Size(184, 31);
            this.btn_dsReport.TabIndex = 1;
            this.btn_dsReport.Text = "Daily Stock Report";
            this.btn_dsReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dsReport.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_dsReport.Click += new System.EventHandler(this.btn_dsReport_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Animated = true;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FillColor = System.Drawing.Color.White;
            this.btn_logout.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 684);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(184, 32);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FillColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(0, 716);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(184, 32);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Animated = true;
            this.btn_reports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reports.FillColor = System.Drawing.Color.White;
            this.btn_reports.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.Black;
            this.btn_reports.Location = new System.Drawing.Point(0, 487);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(184, 45);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Reports";
            this.btn_reports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_reports.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // databasePanel
            // 
            this.databasePanel.BackColor = System.Drawing.Color.White;
            this.databasePanel.Controls.Add(this.btn_invDatabase);
            this.databasePanel.Controls.Add(this.btn_supDatabase);
            this.databasePanel.Controls.Add(this.btn_cusDatabase);
            this.databasePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.databasePanel.Location = new System.Drawing.Point(0, 359);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Size = new System.Drawing.Size(184, 128);
            this.databasePanel.TabIndex = 5;
            // 
            // btn_invDatabase
            // 
            this.btn_invDatabase.Animated = true;
            this.btn_invDatabase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_invDatabase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_invDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_invDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_invDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_invDatabase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_invDatabase.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_invDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_invDatabase.Location = new System.Drawing.Point(0, 62);
            this.btn_invDatabase.Name = "btn_invDatabase";
            this.btn_invDatabase.Size = new System.Drawing.Size(184, 31);
            this.btn_invDatabase.TabIndex = 3;
            this.btn_invDatabase.Text = "Inventory Database";
            this.btn_invDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_invDatabase.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_invDatabase.Click += new System.EventHandler(this.btn_invDatabase_Click);
            // 
            // btn_supDatabase
            // 
            this.btn_supDatabase.Animated = true;
            this.btn_supDatabase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supDatabase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_supDatabase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_supDatabase.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_supDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_supDatabase.Location = new System.Drawing.Point(0, 31);
            this.btn_supDatabase.Name = "btn_supDatabase";
            this.btn_supDatabase.Size = new System.Drawing.Size(184, 31);
            this.btn_supDatabase.TabIndex = 2;
            this.btn_supDatabase.Text = "Supplier Database";
            this.btn_supDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_supDatabase.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_supDatabase.Click += new System.EventHandler(this.btn_supDatabase_Click);
            // 
            // btn_cusDatabase
            // 
            this.btn_cusDatabase.Animated = true;
            this.btn_cusDatabase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cusDatabase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cusDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cusDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cusDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cusDatabase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_cusDatabase.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_cusDatabase.ForeColor = System.Drawing.Color.White;
            this.btn_cusDatabase.Location = new System.Drawing.Point(0, 0);
            this.btn_cusDatabase.Name = "btn_cusDatabase";
            this.btn_cusDatabase.Size = new System.Drawing.Size(184, 31);
            this.btn_cusDatabase.TabIndex = 1;
            this.btn_cusDatabase.Text = "Customer Database";
            this.btn_cusDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_cusDatabase.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_cusDatabase.Click += new System.EventHandler(this.btn_cusDatabase_Click);
            // 
            // btn_database
            // 
            this.btn_database.Animated = true;
            this.btn_database.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_database.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_database.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_database.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_database.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_database.FillColor = System.Drawing.Color.White;
            this.btn_database.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_database.ForeColor = System.Drawing.Color.Black;
            this.btn_database.Location = new System.Drawing.Point(0, 314);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(184, 45);
            this.btn_database.TabIndex = 4;
            this.btn_database.Text = "Database";
            this.btn_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_database.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.White;
            this.registerPanel.Controls.Add(this.btn_supplier);
            this.registerPanel.Controls.Add(this.btn_customer);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerPanel.Location = new System.Drawing.Point(0, 218);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(184, 96);
            this.registerPanel.TabIndex = 3;
            // 
            // btn_supplier
            // 
            this.btn_supplier.Animated = true;
            this.btn_supplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_supplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_supplier.ForeColor = System.Drawing.Color.White;
            this.btn_supplier.Location = new System.Drawing.Point(0, 31);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(184, 31);
            this.btn_supplier.TabIndex = 1;
            this.btn_supplier.Text = "Supplier";
            this.btn_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_supplier.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Animated = true;
            this.btn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.Location = new System.Drawing.Point(0, 0);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(184, 31);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Customer";
            this.btn_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_customer.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_register
            // 
            this.btn_register.Animated = true;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_register.FillColor = System.Drawing.Color.White;
            this.btn_register.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Location = new System.Drawing.Point(0, 173);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(184, 45);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_register.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // managePanel
            // 
            this.managePanel.BackColor = System.Drawing.Color.White;
            this.managePanel.Controls.Add(this.btn_casingstock);
            this.managePanel.Controls.Add(this.btn_tyreproduction);
            this.managePanel.Controls.Add(this.btn_buffingdust);
            this.managePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePanel.Location = new System.Drawing.Point(0, 45);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(184, 128);
            this.managePanel.TabIndex = 1;
            // 
            // btn_casingstock
            // 
            this.btn_casingstock.Animated = true;
            this.btn_casingstock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_casingstock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_casingstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_casingstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_casingstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_casingstock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_casingstock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_casingstock.ForeColor = System.Drawing.Color.White;
            this.btn_casingstock.Location = new System.Drawing.Point(0, 62);
            this.btn_casingstock.Name = "btn_casingstock";
            this.btn_casingstock.Size = new System.Drawing.Size(184, 31);
            this.btn_casingstock.TabIndex = 2;
            this.btn_casingstock.Text = "Casing Stock";
            this.btn_casingstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_casingstock.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_casingstock.Click += new System.EventHandler(this.btn_casingstock_Click);
            // 
            // btn_tyreproduction
            // 
            this.btn_tyreproduction.Animated = true;
            this.btn_tyreproduction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tyreproduction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tyreproduction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tyreproduction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tyreproduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tyreproduction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_tyreproduction.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_tyreproduction.ForeColor = System.Drawing.Color.White;
            this.btn_tyreproduction.Location = new System.Drawing.Point(0, 31);
            this.btn_tyreproduction.Name = "btn_tyreproduction";
            this.btn_tyreproduction.Size = new System.Drawing.Size(184, 31);
            this.btn_tyreproduction.TabIndex = 1;
            this.btn_tyreproduction.Text = "Tyre Production";
            this.btn_tyreproduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_tyreproduction.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_tyreproduction.Click += new System.EventHandler(this.btn_tyreproduction_Click);
            // 
            // btn_buffingdust
            // 
            this.btn_buffingdust.Animated = true;
            this.btn_buffingdust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buffingdust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buffingdust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buffingdust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buffingdust.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buffingdust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.btn_buffingdust.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_buffingdust.ForeColor = System.Drawing.Color.White;
            this.btn_buffingdust.Location = new System.Drawing.Point(0, 0);
            this.btn_buffingdust.Name = "btn_buffingdust";
            this.btn_buffingdust.Size = new System.Drawing.Size(184, 31);
            this.btn_buffingdust.TabIndex = 0;
            this.btn_buffingdust.Text = "Buffing Dust";
            this.btn_buffingdust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_buffingdust.TextOffset = new System.Drawing.Point(30, 0);
            this.btn_buffingdust.Click += new System.EventHandler(this.btn_buffingdust_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.Animated = true;
            this.btn_manage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_manage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_manage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_manage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_manage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manage.FillColor = System.Drawing.Color.White;
            this.btn_manage.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.Black;
            this.btn_manage.Location = new System.Drawing.Point(0, 0);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(184, 45);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Manage";
            this.btn_manage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_manage.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.BackColor = System.Drawing.Color.White;
            this.displayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayPanel.ForeColor = System.Drawing.Color.White;
            this.displayPanel.Location = new System.Drawing.Point(184, 26);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(959, 748);
            this.displayPanel.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(871, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "BOMBUWALA RUBBER MILLS PVT (LTD)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_email
            // 
            this.btn_email.Animated = true;
            this.btn_email.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_email.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_email.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_email.FillColor = System.Drawing.Color.White;
            this.btn_email.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.ForeColor = System.Drawing.Color.Black;
            this.btn_email.Location = new System.Drawing.Point(0, 632);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(184, 45);
            this.btn_email.TabIndex = 10;
            this.btn_email.Text = "Email";
            this.btn_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_email.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1143, 774);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.reportsPanel.ResumeLayout(false);
            this.databasePanel.ResumeLayout(false);
            this.registerPanel.ResumeLayout(false);
            this.managePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel menuPanel;
        private Guna.UI2.WinForms.Guna2Button btn_reports;
        private System.Windows.Forms.Panel databasePanel;
        private Guna.UI2.WinForms.Guna2Button btn_cusDatabase;
        private Guna.UI2.WinForms.Guna2Button btn_database;
        private System.Windows.Forms.Panel registerPanel;
        private Guna.UI2.WinForms.Guna2Button btn_supplier;
        private Guna.UI2.WinForms.Guna2Button btn_customer;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private System.Windows.Forms.Panel managePanel;
        private Guna.UI2.WinForms.Guna2Button btn_casingstock;
        private Guna.UI2.WinForms.Guna2Button btn_tyreproduction;
        private Guna.UI2.WinForms.Guna2Button btn_buffingdust;
        private Guna.UI2.WinForms.Guna2Button btn_manage;
        private System.Windows.Forms.Panel displayPanel;
        private Guna.UI2.WinForms.Guna2Button btn_invDatabase;
        private Guna.UI2.WinForms.Guna2Button btn_supDatabase;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel reportsPanel;
        private Guna.UI2.WinForms.Guna2Button btn_wsReport;
        private Guna.UI2.WinForms.Guna2Button btn_dsReport;
        private Guna.UI2.WinForms.Guna2Button btn_email;
    }
}