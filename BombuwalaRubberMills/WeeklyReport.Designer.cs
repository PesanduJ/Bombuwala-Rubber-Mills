namespace BombuwalaRubberMills
{
    partial class WeeklyReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_load = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtToDate = new MetroFramework.Controls.MetroDateTime();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtFromDate = new MetroFramework.Controls.MetroDateTime();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            
            this.SuspendLayout();
            // 
           
            // 
            // btn_load
            // 
            this.btn_load.Depth = 0;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(1060, 169);
            this.btn_load.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_load.Name = "btn_load";
            this.btn_load.Primary = true;
            this.btn_load.Size = new System.Drawing.Size(145, 37);
            this.btn_load.TabIndex = 136;
            this.btn_load.TabStop = false;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Location = new System.Drawing.Point(1032, 114);
            this.dtToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 29);
            this.dtToDate.TabIndex = 134;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(938, 116);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(33, 27);
            this.guna2HtmlLabel4.TabIndex = 135;
            this.guna2HtmlLabel4.Text = "To :";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Location = new System.Drawing.Point(1032, 61);
            this.dtFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 29);
            this.dtFromDate.TabIndex = 132;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(938, 63);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(55, 27);
            this.guna2HtmlLabel7.TabIndex = 133;
            this.guna2HtmlLabel7.Text = "From :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Underline);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(54, 380);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(294, 27);
            this.guna2HtmlLabel1.TabIndex = 130;
            this.guna2HtmlLabel1.Text = "Tyre Production Weekly Report";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Underline);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(54, 28);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(262, 27);
            this.guna2HtmlLabel3.TabIndex = 129;
            this.guna2HtmlLabel3.Text = "Buffing Dust Weekly Report";
            
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 1100);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_load;
        private MetroFramework.Controls.MetroDateTime dtToDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private MetroFramework.Controls.MetroDateTime dtFromDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
       
    }
}