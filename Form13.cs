using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class formAshop : Form
    {
        public formAshop()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            SqlConnect sqlConnectIDcheck = new SqlConnect();
            string sqlQuery = "SELECT TOP 1 shopID From Shops ORDER BY shopID DESC ";
            DataTable result = sqlConnectIDcheck.Exequery(sqlQuery);

            if (result.Rows.Count > 0)
            {
                int lastID = int.Parse(result.Rows[0][0].ToString());
                ++lastID;
                this.txtID.Text = lastID.ToString();


            }
            else
            {
                this.txtID.Text = "1";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnectInsert = new SqlConnect();
            string sqlQuery2 = "INSERT INTO Shops VALUES ('" + this.txtID.Text + "', '" + this.txtName.Text + "', '" + this.txtAddress.Text + "')";
            sqlConnectInsert.ExeNonQuery(sqlQuery2);

            if (sqlConnectInsert.rMsg != "Error executing non-query")
            {
                MessageBox.Show("Adding record successfull");
            }
            else
            {
                MessageBox.Show("Adding record unsuccessfull");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
