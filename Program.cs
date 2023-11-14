using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace FP
{
    public static class GlobalData
    {
        public static string SingleProduct { get; set; }
        public static List<string> Products { get; set; }
    }

    public class SqlConnect
    {
        private string conString;
        private SqlConnection con;
        public string rMsg;

        public SqlConnect()
        {
            this.conString = @"Data Source=DESKTOP-PH953N5\SQLEXPRESS;Initial Catalog=FB;Integrated Security=True";
            this.con = new SqlConnection(conString);
            this.con.Open();
        }

        public void Closecon()
        {
            this.con.Close();
        }

        public DataTable Exequery(string exeQuery)
        {
            var dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(exeQuery, this.con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception)
            {
                rMsg = "Error executing query";
            }
            finally
            {
                this.Closecon();
            }
            return dataTable;
        }

        public int ExeNonQuery(string exeQuery)
        {
            int status = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(exeQuery, this.con))
                {
                    status = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                rMsg = "Error executing non-query";
            }
            finally
            {
                Closecon();
            }
            return status;
        }
    }
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formAuth());
        }
    }
}
