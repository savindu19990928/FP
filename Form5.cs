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
    public partial class formAexport : Form
    {
        public formAexport()
        {
            InitializeComponent();
        }

        private bool indexChanged = false;
        private bool dropClosed = false;

        private void formAexport_Load(object sender, EventArgs e)
        {
            SqlConnect sqlconnectionShop = new SqlConnect();
            string shopsQ = "SELECT shopID FROM Shops";
            DataTable st = sqlconnectionShop.Exequery(shopsQ);
            List<string> listShops = st.AsEnumerable().Select(row => row.Field<string>("shopID")).ToList();
            this.comboShopID.Items.AddRange(listShops.ToArray());
            

            SqlConnect sqlconnection = new SqlConnect();
            DataTable resultp = sqlconnection.Exequery("SELECT ProductName FROM Products");

            GlobalData.Products = resultp.AsEnumerable().Select(row => row.Field<string>("ProductName")).ToList();

            SqlConnect sqlConnectIDcheck = new SqlConnect();
            string sqlQuery = "SELECT TOP 1 exportedID From Exports ORDER BY exportedID DESC ";
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

            this.datePicker.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ivalidator.AreInputsEmptyET(this) || String.IsNullOrEmpty(this.comboShopID.Text))
            {
                MessageBox.Show("Please fill requiered fields!");
                return;
            }

            SqlConnect sqlConnectInsertCheck = new SqlConnect();
            string sqlQuery0 = "SELECT stockCount FROM Products WHERE productName='" + this.txtName.Text + "'";
            DataTable stockNumDT = sqlConnectInsertCheck.Exequery(sqlQuery0);

            int stockNum = int.Parse(stockNumDT.Rows[0][0].ToString());
            int expStockNum = int.Parse(this.stockCount.Value.ToString());
            int newStockNum = stockNum - expStockNum;

            if (newStockNum < 0)
            {
                MessageBox.Show("Invalid record exist!");
                return;
            }

            if (sqlConnectInsertCheck.rMsg == "Error executing query")
            {
                MessageBox.Show("Product name invalid!");
                return;
            }

            SqlConnect sqlConnectRE = new SqlConnect();
            string exeNonQuery = @"SELECT (SELECT SUM(importedCount) FROM Imports WHERE importedProduct='" + this.txtName.Text + "'" + ") - (SELECT SUM(exportedCount) FROM Exports WHERE exportedProduct='" + this.txtName.Text + "') AS StockDifference";
            DataTable stockDifferenceDT = sqlConnectRE.Exequery(exeNonQuery);
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

            string sqlQuery1 = @"UPDATE Products SET stockCount=" + stockDifference + " WHERE " + "productName='" + this.txtName.Text + "'";
            SqlConnect sqlConnectStockUpdate = new SqlConnect();
            sqlConnectStockUpdate.ExeNonQuery(sqlQuery1);

            SqlConnect sqlConnectInsert = new SqlConnect();
            string sqlQuery2 = @"INSERT INTO Exports VALUES ('" + this.txtID.Text + "', '" + this.txtName.Text + "', " + this.stockCount.Value.ToString() + ", '" + this.comboShopID.Text + "', '" + this.txtStatus.Text + "', '" + this.datePicker.Value.ToString("yyyy-MM-dd") + "')";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (indexChanged || dropClosed)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                string searchText = txtName.Text.ToLower();

                comboSearch.Items.Clear();

                foreach (string product in GlobalData.Products)
                {
                    if (product != null && product.ToLower().Contains(searchText))
                    {
                        comboSearch.Items.Add(product);
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
            txtName.Text = comboSearch.GetItemText(comboSearch.SelectedItem);
            indexChanged = false;
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
    }
}
