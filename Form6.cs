using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class formImportR : Form
    {
        public formImportR()
        {
            InitializeComponent();
        }

        private void formImport_Load(object sender, EventArgs e)
        {
            if (GlobalData.isADMIN)
            {
                this.addUserToolStripMenuItem.Visible = true;
                this.manageProductToolStripMenuItem.Visible = true;
                this.manageShopsToolStripMenuItem.Visible = true;
            }

            ReportDocument reportDocument = new ReportDocument();

            string appPath = Application.StartupPath;
            string path = Path.GetFullPath(Path.Combine(appPath, @"..\..\"));
            reportDocument.Load(Path.Combine(path, "CrystalReportImp.rpt"));

            crystalReportViewer1.ReportSource = reportDocument;
        }
        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSearch formSearch = new formSearch();
            formSearch.Show();
        }

        private void importReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formImportR formImport = new formImportR();
            formImport.Show();
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formExport formExport = new formExport();
            formExport.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAuth formAuth = new formAuth();
            formAuth.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct addProductform = new addProduct();
            addProductform.Show();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEproduct formEproduct = new formEproduct();
            formEproduct.Show();
        }

        private void importProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAimport importformadd = new formAimport();
            importformadd.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEimport importformedit = new formEimport();
            importformedit.Show();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAexport exportformadd = new formAexport();
            exportformadd.Show();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEexport exportformedit = new formEexport();
            exportformedit.Show();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formAuser formAuser = new formAuser();
            formAuser.Show();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRuser formRuser = new formRuser();
            formRuser.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCP formCP = new formCP();
            formCP.Show();
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAshop formAshop = new formAshop();
            formAshop.Show();
        }

        private void editShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEshop formEshop = new formEshop();
            formEshop.Show();
        }
    }
}