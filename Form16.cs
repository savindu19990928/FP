using Microsoft.SqlServer.Server;
using System;
using System.Collections;
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
    public partial class formCP : Form
    {
        public formCP()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ivalidator.AreInputsEmpty(this))
            {
                MessageBox.Show("Please fill requiered fields!");
                return;
            }

            string passhash = BCrypt.Net.BCrypt.HashPassword(this.txtPass.Text, BCrypt.Net.BCrypt.GenerateSalt(12));
            if (GlobalData.isADMIN == true && this.txtPass.Text == this.txtPass2.Text)
            {
                SqlConnect sqlConnectA = new SqlConnect();
                string queryA = @"UPDATE Admin SET password='" + passhash + "'";
                sqlConnectA.ExeNonQuery(queryA);
                MessageBox.Show("Password change successful!");
                this.Close();
                return;
            }
            if (this.txtPass.Text == this.txtPass2.Text)
            {
                SqlConnect sqlConnect = new SqlConnect();
                string query = @"UPDATE Auth SET password='" + passhash + "' WHERE userName='" + GlobalData.cUser + "'";
                sqlConnect.ExeNonQuery(query);
                MessageBox.Show("Password change successful!");
                this.Close();
                return;
            }
            MessageBox.Show("Passwords don't match!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
