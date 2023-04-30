using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace BombuwalaRubberMills
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();



        private void btn_load_Click(object sender, EventArgs e)
        {
            
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
        }

        private void btn_load_Click_1(object sender, EventArgs e)
        {
            //this.getBuffingDustReportTableAdapter.Fill(this.bombuwalarubbermillsDataSet.GetBuffingDustReport, dtFromDate.Value, dtToDate.Value);
            //this.getTyreProductionReportTableAdapter.Fill(this.bombuwalarubbermillsDataSet.GetTyreProductionReport, dtFromDate.Value, dtToDate.Value);
            //this.getCasingStockReportTableAdapter.Fill(this.bombuwalarubbermillsDataSet.GetCasingStockReport, dtFromDate.Value, dtToDate.Value);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }
    }
}
