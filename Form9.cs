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
    public partial class formEproduct : Form
    {
        public formEproduct()
        {
            InitializeComponent();
        }

        private bool indexChanged = false;
        private bool dropClosed = false;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (indexChanged || dropClosed)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                string searchText = txtSearch.Text.ToLower();

                comboP.Items.Clear();

                foreach (string product in GlobalData.Products)
                {
                    if (product != null && product.ToLower().Contains(searchText))
                    {
                        comboP.Items.Add(product);
                    }
                }

                if (comboP.Items.Count > 0)
                {
                    comboP.DroppedDown = true;
                }
                else
                {
                    comboP.DroppedDown = false;
                }
            }
            else
            {
                comboP.Items.Clear();
                comboP.DroppedDown = false;
            }
        }

        private void formEproduct_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnectionEp = new SqlConnect();
            DataTable result = sqlconnectionEp.Exequery("SELECT ProductName FROM Products");

            GlobalData.Products = result.AsEnumerable().Select(row => row.Field<string>("ProductName")).ToList();
        }

        private void comboP_DropDownClosed(object sender, EventArgs e)
        {
            if (indexChanged)
            {
                return;
            }
            dropClosed = true;
            comboP.SelectedIndex = -1;
            dropClosed = false;
        }

        private void comboP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            indexChanged = true;
            txtSearch.Text = comboP.GetItemText(comboP.SelectedItem);
            indexChanged = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ivalidator.AreInputsEmpty(this))
            {
                MessageBox.Show("Please fill requiered fields!");
                return;
            }

            SqlConnect sqlConnectionUp = new SqlConnect();
            string upQuery = @"UPDATE Products SET productName='" + txtNname.Text + "' WHERE productName='" + txtSearch.Text + "'";
            int status0 = sqlConnectionUp.ExeNonQuery(upQuery);

            if (status0 > 0)
            {
                MessageBox.Show("Updating successfull");
            }
            else
            {
                MessageBox.Show("Updating unsuccessfull");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnect sqlConnectionUp = new SqlConnect();
            string upQuery = "DELETE FROM Products WHERE productName='" + txtSearch.Text + "'";
            int status = sqlConnectionUp.ExeNonQuery(upQuery);

            if (status > 0)
            {
                MessageBox.Show("Deleting successfull");
            }
            else
            {
                MessageBox.Show("Deleting unsuccessfull");
            }
        }

        private void txtNname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
