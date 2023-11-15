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
    public partial class formRuser : Form
    {
        public formRuser()
        {
            InitializeComponent();
        }

        private void formRuser_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();
            DataTable result = sqlconnection.Exequery("SELECT userName FROM Auth");

            List <string> users = result.AsEnumerable().Select(row => row.Field<string>("userName")).ToList();

            this.comboName.Items.AddRange(users.ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Ivalidator.AreInputsEmpty(this))
            {
                MessageBox.Show("Please fill requiered fields!");
                return;
            }

            SqlConnect sqlconnection1 = new SqlConnect();
            string query = "DELETE FROM Auth WHERE userName='" + this.comboName.Text + "'";
            sqlconnection1.Exequery(query);
            MessageBox.Show("User deletion successful!");
        }
    }
}
