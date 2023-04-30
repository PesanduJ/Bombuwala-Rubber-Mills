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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //this.getBuffingDustWeeklyReportTableAdapter.Fill(this.bombuwalarubbermillsDataSet.GetBuffingDustWeeklyReport, dtFromDate.Value, dtToDate.Value);
           // this.getTyreProductionWeeklyReportTableAdapter.Fill(this.bombuwalarubbermillsDataSet.GetTyreProductionWeeklyReport, dtFromDate.Value, dtToDate.Value);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
