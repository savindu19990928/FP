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
    public partial class formEshop : Form
    {
        public formEshop()
        {
            InitializeComponent();
        }

        private void formEshop_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();
            DataTable resultp = sqlconnection.Exequery("SELECT shopID FROM shops");
            List <string> comboItems = resultp.AsEnumerable().Select(row => row.Field<string>("shopID")).ToList();
            this.comboID.Items.AddRange(comboItems.ToArray());
        }

        private void comboID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnect sqlConnectpd = new SqlConnect();
            string exequery = "SELECT * FROM Shops WHERE shopID='" + this.comboID.Text + "'";
            DataTable result = sqlConnectpd.Exequery(exequery);

            this.txtName.Text = result.Rows[0][1].ToString();
            this.txtAddress.Text = result.Rows[0][2].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnectpd = new SqlConnect();
            string exequery = @"UPDATE Shops SET shopName='" + this.txtName.Text + "', shopAddress='" + this.txtAddress.Text + "' WHERE shopID='" + this.comboID.Text + "'";
            sqlConnectpd.ExeNonQuery(exequery);
            MessageBox.Show("Record update successful!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnectRR1 = new SqlConnect();
            string exeNonquery1 = "DELETE FROM Shops WHERE shopID='" + this.comboID.Text + "'";
            sqlConnectRR1.ExeNonQuery(exeNonquery1);
            MessageBox.Show("Record deletion successful!");
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
