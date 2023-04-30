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
    public partial class InventoryDatabaseView : Form
    {
        public InventoryDatabaseView()
        {
            InitializeComponent();
        }

        DatabaseConnection dc = new DatabaseConnection();

        public void loadData()
        {
            buffingDustDataGridView.DataSource = dc.display("select * from Buffing_Dust");
            tyreProductionDataGridView.DataSource = dc.display("select * from Tyre_Production");
            casingStockDataGridView.DataSource = dc.display("select * from Casing_Stock");
        }

        private void InventoryDatabaseView_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_clearBD_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime weekbefore = DateTime.Now.AddDays(-7);
                string query = "delete from Buffing_Dust where Date < '" + weekbefore + "' ";

                int i = dc.save_update_delete(query);

                if (i == 0)
                {
                    MessageBox.Show(this, "Data cleared successfully!");
                    loadData();
                }
            }

            catch (SQLiteException)
            {
                MessageBox.Show("Databse Error, Cannot clear data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error encountered, Please restart the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clearTP_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime weekbefore = DateTime.Now.AddDays(-7);
                string query = "delete from Tyre_Production where Date < '" + weekbefore + "'";

                int i = dc.save_update_delete(query);

                if (i == 0)
                {
                    MessageBox.Show(this, "Data cleared successfully!");
                    loadData();
                }
            }

            catch (SQLiteException)
            {
                MessageBox.Show("Databse Error, Cannot clear data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error encountered, Please restart the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clearCS_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime weekbefore = DateTime.Now.AddDays(-7);
                string query = "delete from Casing_Stock where Date < '" + weekbefore + "'";

                int i = dc.save_update_delete(query);

                if (i == 0)
                {
                    MessageBox.Show(this, "Data cleared successfully!");
                    loadData();
                }
            }

            catch (SQLiteException)
            {
                MessageBox.Show("Databse Error, Cannot clear data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Error encountered, Please restart the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
