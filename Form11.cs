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
    public partial class formEimport : Form
    {
        public formEimport()
        {
            InitializeComponent();
        }

        private bool indexChanged = false;
        private bool dropClosed = false;
        private bool indexChanged1 = false;
        private bool dropClosed1 = false;

        private void formEimport_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnection = new SqlConnect();
            DataTable resultp = sqlconnection.Exequery("SELECT importedID FROM Imports");

            GlobalData.Imports = resultp.AsEnumerable().Select(row => row.Field<string>("importedID")).ToList();

            SqlConnect sqlconnection1 = new SqlConnect();
            DataTable resulti = sqlconnection.Exequery("SELECT ProductName FROM Products");

            GlobalData.Products = resulti.AsEnumerable().Select(row => row.Field<string>("ProductName")).ToList();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (indexChanged || dropClosed)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                string searchText = txtID.Text.ToLower();

                comboSearch.Items.Clear();

                foreach (string productI in GlobalData.Imports)
                {
                    if (productI != null && productI.ToLower().Contains(searchText))
                    {
                        comboSearch.Items.Add(productI);
                    }
                }

                if (comboSearch.Items.Count > 0)
                {
                    comboSearch.DroppedDown = true;
                }
                else
                {
                    comboSearch.DroppedDown = false;
                }
            }
            else
            {
                comboSearch.Items.Clear();
                comboSearch.DroppedDown = false;
            }
        }

        private void comboSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            indexChanged = true;
            indexChanged1 = true;
            txtID.Text = comboSearch.GetItemText(comboSearch.SelectedItem);

            SqlConnect sqlConnectpd = new SqlConnect();
            string exequery = "SELECT * FROM Imports WHERE importedID='" + this.txtID.Text + "'";
            DataTable result = sqlConnectpd.Exequery(exequery);

            this.txtName.Text = result.Rows[0][1].ToString();
            this.stockCount.Value = int.Parse(result.Rows[0][2].ToString());
            this.txtStatus.Text = result.Rows[0][3].ToString();
            this.datePicker.Value = DateTime.Parse(result.Rows[0][4].ToString());

            indexChanged = false;
            indexChanged1 = false;
        }

        private void comboSearch_DropDownClosed(object sender, EventArgs e)
        {
            if (indexChanged)
            {
                return;
            }
            dropClosed = true;
            comboSearch.SelectedIndex = -1;
            dropClosed = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (indexChanged1 || dropClosed1)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                string searchText = txtName.Text.ToLower();

                comboName.Items.Clear();

                foreach (string product in GlobalData.Products)
                {
                    if (product != null && product.ToLower().Contains(searchText))
                    {
                        comboName.Items.Add(product);
                    }
                }

                if (comboName.Items.Count > 0)
                {
                    comboName.DroppedDown = true;
                }
                else
                {
                    comboName.DroppedDown = false;
                }
            }
            else
            {
                comboName.Items.Clear();
                comboName.DroppedDown = false;
            }
        }

        private void comboName_DropDownClosed(object sender, EventArgs e)
        {
            if (indexChanged1)
            {
                return;
            }
            dropClosed1 = true;
            comboName.SelectedIndex = -1;
            dropClosed1 = false;
        }

        private void comboName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            indexChanged1 = true;
            txtName.Text = comboName.GetItemText(comboName.SelectedItem);
            indexChanged1 = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Imports.Contains(this.txtID.Text))
            {
                MessageBox.Show("Import ID is invalid!");
                return;
            }

            SqlConnect sqlConnectRR1 = new SqlConnect();
            string exeNonquery1 = "DELETE FROM Imports WHERE importedID='" + this.txtID.Text + "'";
            sqlConnectRR1.ExeNonQuery(exeNonquery1);

            SqlConnect sqlConnectRE2 = new SqlConnect();
            string exeNonquery2 = "SELECT SUM(importedCount) FROM Imports";
            DataTable newStockDT = sqlConnectRE2.Exequery(exeNonquery2);
            int newStock = 0;
            if (newStockDT.Rows[0][0] != DBNull.Value)
            {
                newStock = int.Parse(newStockDT.Rows[0][0].ToString());
            }

            SqlConnect sqlConnectRE0 = new SqlConnect();
            string exeNonquery0 = "SELECT SUM(exportedCount) FROM Exports";
            DataTable newStockDT1 = sqlConnectRE0.Exequery(exeNonquery0);
            int newStock1 = 0;
            if (newStockDT1.Rows[0][0] != DBNull.Value)
            {
                newStock1 = int.Parse(newStockDT1.Rows[0][0].ToString());
            }

            int newStock3 = newStock - newStock1;

            if (newStock3 < 0)
            {
                MessageBox.Show("Invalid record exist!");
                return;
            }

            SqlConnect sqlConnectRR3 = new SqlConnect();
            string exeNonquery3 = "UPDATE Products SET stockCount=" + newStock3 + " WHERE productName='" + this.txtName.Text + "'";
            sqlConnectRR3.ExeNonQuery(exeNonquery3);

            MessageBox.Show("Record deletion successful!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!GlobalData.Imports.Contains(this.txtID.Text))
            {
                MessageBox.Show("Import ID is invalid!");
                return;
            }

            if (Ivalidator.AreInputsEmptyET(this))
            {
                MessageBox.Show("Please fill requiered fields!");
                return;
            }

            SqlConnect sqlConnectRE = new SqlConnect();
            string exeNonquery = "UPDATE Imports SET importedProduct='" + this.txtName.Text + "' , importedCount=" + this.stockCount.Value + ", importStatus='" + this.txtStatus.Text + "' , importDate='" + this.datePicker.Value.ToString("yyyy-MM-dd") + "' " + "WHERE importedID='" + this.txtID.Text + "'";

            SqlConnect sqlConnectRE1 = new SqlConnect();
            string exeNonQuery = @"SELECT (SELECT SUM(importedCount) FROM Imports WHERE importedProduct='" + this.txtName.Text + "'" + ") - (SELECT SUM(exportedCount) FROM Exports WHERE exportedProduct='" + this.txtName.Text + "') AS StockDifference";
            DataTable stockDifferenceDT = sqlConnectRE1.Exequery(exeNonQuery);
            int stockDifference = 0;

            if (stockDifferenceDT.Rows[0]["StockDifference"] != DBNull.Value)
            {
                stockDifference = Convert.ToInt32(stockDifferenceDT.Rows[0]["StockDifference"]);
            }

            if (stockDifference < 0)
            {
                MessageBox.Show("Invalid record exist!");
                return;
            }

            SqlConnect sqlConnectRE3 = new SqlConnect();
            string exeNonquery3 = "UPDATE Products SET stockCount=" + stockDifference + " WHERE productName='" + this.txtName.Text + "'";
            sqlConnectRE3.ExeNonQuery(exeNonquery3);

            MessageBox.Show("Record Update successful!");
        }
    }
}
