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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();

            string query = @"SELECT * FROM Products WHERE productName='" + this.txtSearch.Text + "'";
            DataTable result = sqlconnection.Exequery(query);


            if (result.Rows.Count > 0)
            {
                GlobalData.SingleProduct = this.txtSearch.Text;
                this.Hide();
                formSproduct formSproduct = new formSproduct();
                formSproduct.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid product name", "Product name invalid!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            txtSearch.Items.Clear();

            foreach (string product in GlobalData.Products)
            {
                if (product.Contains(searchText))
                {
                    Console.WriteLine(product);
                    txtSearch.Items.Add(product);
                }
            }

            txtSearch.DroppedDown = true;
        }

        private void formSearch_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();
            DataTable result = sqlconnection.Exequery("SELECT ProductName FROM Products");

            GlobalData.Products = result.AsEnumerable().Select(row => row.Field<string>("ProductName")).ToList();
            Console.WriteLine(GlobalData.Products);
        }
    }
}
