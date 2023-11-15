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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void cancelBtnAP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPbtn_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnectAP = new SqlConnect();

            string query = @"INSERT INTO Products VALUES ('" + this.aptxt.Text +"', 0)";
            sqlConnectAP.ExeNonQuery(query);
            if (sqlConnectAP.rMsg != "Error executing non-query")
            {
                MessageBox.Show("Product added successfully");
            }
            else
            {
                MessageBox.Show("Product adding unsuccessfull");
            }
        }

        private void aptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
