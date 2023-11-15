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
    public partial class formAuser : Form
    {
        public formAuser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnect = new SqlConnect();
            string sql = "SELECT userName FROM Auth";
            DataTable dt = sqlConnect.Exequery(sql);
            List<string> dtlist = dt.AsEnumerable().Select(row => row.Field<string>("userName")).ToList();
            if (this.txtName.Text == "Admin" || dtlist.Contains(this.txtName.Text))
            {
                MessageBox.Show("Please select different username!");
                return;
            }
            string passhash = BCrypt.Net.BCrypt.HashPassword(this.txtPass.Text, BCrypt.Net.BCrypt.GenerateSalt(12));

            SqlConnect sqlConnect1 = new SqlConnect();
            string sql1 = "INSERT INTO Auth VALUES ('" + this.txtName.Text + "', '" + passhash + "')";
            sqlConnect1.ExeNonQuery(sql1);
            MessageBox.Show("User creation successful!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
