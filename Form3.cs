using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FP
{
    public partial class formSearch : Form
    {
        public formSearch()
        {
            InitializeComponent();
        }

        private bool indexChanged = false;
        private bool dropClosed = false;
        private string si;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();

            string query = @"SELECT * FROM Products WHERE productName='" + this.searchBar.Text + "'";
            DataTable result = sqlconnection.Exequery(query);


            if (result.Rows.Count > 0)
            {
                GlobalData.SingleProduct = this.searchBar.Text;
                this.Hide();
                formSproduct formSproduct = new formSproduct();
                formSproduct.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid product name", "Product name invalid!");
            }
        }

        private void formSearch_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();
            DataTable result = sqlconnection.Exequery("SELECT ProductName FROM Products");

            GlobalData.Products = result.AsEnumerable().Select(row => row.Field<string>("ProductName")).ToList();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (indexChanged || dropClosed)
            {
                return;
            }

            if (!string.IsNullOrEmpty(searchBar.Text))
            {
                string searchText = searchBar.Text.ToLower();

                txtSearch.Items.Clear();

                foreach (string product in GlobalData.Products)
                {
                    if (product != null && product.ToLower().Contains(searchText))
                    {
                        txtSearch.Items.Add(product);
                    }
                }

                if (txtSearch.Items.Count > 0)
                {
                    txtSearch.DroppedDown = true;
                }
                else
                {
                    txtSearch.DroppedDown = false;
                }
            }
            else
            {
                txtSearch.Items.Clear();
                txtSearch.DroppedDown = false;
            }
        }

        private void txtSearch_DropDownClosed(object sender, EventArgs e)
        {
            if (indexChanged)
            {
                return;
            }
            dropClosed = true;
            txtSearch.SelectedIndex = -1;
            dropClosed = false;
        }

        private void txtSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            indexChanged = true;
            if (si == txtSearch.GetItemText(txtSearch.SelectedItem))
            {
                searchBar.Text = si;
            }
            si = txtSearch.GetItemText(txtSearch.SelectedItem);
            indexChanged = false;
        }
    }
}
