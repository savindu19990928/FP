using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace FP
{
    public partial class formAuth : Form
    {
        public formAuth()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (this.txtuser.Text == "Admin")
            {
                SqlConnect sqlConnectA = new SqlConnect();
                string queryA = "SELECT password FROM Admin";
                DataTable dtA = sqlConnectA.Exequery(queryA);
                if (BCrypt.Net.BCrypt.Verify(this.textpass.Text, dtA.Rows[0][0].ToString()))
                {
                    GlobalData.isADMIN = true;
                    GlobalData.cUser = "Admin";
                    this.Hide();
                    formMain formMain = new formMain();
                    formMain.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Please enter valid Password!", "Wrong Credentials");
                }
                return;
            }
            SqlConnect sqlconnection = new SqlConnect();

            string query = @"SELECT * FROM Auth WHERE userName='" + this.txtuser.Text + "'";
            DataTable result = sqlconnection.Exequery(query);

            if (result.Rows.Count > 0)
            {
                if (BCrypt.Net.BCrypt.Verify(this.textpass.Text, result.Rows[0][1].ToString()))
                {
                    GlobalData.cUser = this.txtuser.Text;
                    GlobalData.isADMIN = false;
                    this.Hide();
                    formMain formMain = new formMain();
                    formMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter valid Password!", "Wrong Credentials");
                }
            } else 
            {
                MessageBox.Show("Please enter valid Username!", "Wrong Credentials");
            }
        }
    }
}
