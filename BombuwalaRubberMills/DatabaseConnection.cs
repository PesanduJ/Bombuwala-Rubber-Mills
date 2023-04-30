using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BombuwalaRubberMills
{
    internal class DatabaseConnection
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        SQLiteDataReader dr;
        
    
        public DatabaseConnection() //Default Constructor
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                
                using(var con = new SQLiteConnection(@"Data Source=" + path))
                {
                    string Manager = "CREATE TABLE IF NOT EXISTS Manager(" +
                    "NIC varchar(15) PRIMARY KEY," +
                    "First_Name varchar(50)," +
                    "Last_Name varchar(50)," +
                    "DOB datetime," +
                    "Gender varchar(20)," +
                    "Email_Address varchar(100)," +
                    "Telephone_Number int," +
                    "Address varcahr(250)," +
                    "Password varchar(100))";

                    string Customer = "CREATE TABLE IF NOT EXISTS Customer(" +
                    "CID integer PRIMARY KEY AUTOINCREMENT," +
                    "First_Name varchar(50)," +
                    "Last_Name varchar(50)," +
                    "Telephone_Number int," +
                    "Email_Address varchar(100)," +
                    "Address varcahr(250))";

                    string Supplier = "CREATE TABLE IF NOT EXISTS Supplier(" +
                    "SID integer PRIMARY KEY AUTOINCREMENT," +
                    "First_Name varchar(50)," +
                    "Last_Name varchar(50)," +
                    "Telephone_Number int," +
                    "Email_Address varchar(100)," +
                    "Address varcahr(250))";

                    string Buffing_Dust = "CREATE TABLE IF NOT EXISTS Buffing_Dust(" +
                    "Date datetime," +
                    "BName varchar(50)," +
                    "BPrice int," +
                    "Production int," +
                    "Dispatch int," +
                    "Remaining int)";

                    string Casing_Stock = "CREATE TABLE IF NOT EXISTS Casing_Stock(" +
                    "Date datetime," +
                    "CName varchar(50)," +
                    "Brought_Forward int," +
                    "Received int," +
                    "Cast_Off int," +
                    "Used int," +
                    "Total int)";

                    string Tyre_Production = "CREATE TABLE IF NOT EXISTS Tyre_Production(" +
                    "Date datetime," +
                    "TName varchar(50)," +
                    "TPrice int," +
                    "Production int," +
                    "Dispatch int," +
                    "Rejected int," +
                    "Balance int," +
                    "Total int)";

               

                    con.Open();
                    cmd = new SQLiteCommand(Manager, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Customer, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Supplier, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Buffing_Dust, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Casing_Stock, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Tyre_Production, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            con = new SQLiteConnection(cs);

        }

        public int save_update_delete(string query)
        {
            con.Open();
            cmd = new SQLiteCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i;
        }

        public DataTable display(string query)
        {
            con.Open();


            da = new SQLiteDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            return dt;
        }
        
        public int searchData(string query)
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.CommandType = CommandType.Text;
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            return count;
        }

    }
}
