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
    public partial class formExport : Form
    {
        public formExport()
        {
            InitializeComponent();
        }

        private void formExport_Load(object sender, EventArgs e)
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
            reportDocument.Load(Path.Combine(path, "CrystalReportEXP.rpt"));

            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSearch formSearch = new formSearch();
            formSearch.ShowDialog();
        }

        private void importReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formImportR formImport = new formImportR();
            formImport.ShowDialog();
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formExport formExport = new formExport();
            formExport.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAuth formAuth = new formAuth();
            formAuth.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct addProductform = new addProduct();
            addProductform.ShowDialog();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEproduct formEproduct = new formEproduct();
            formEproduct.ShowDialog();
        }

        private void importProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAimport importformadd = new formAimport();
            importformadd.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEimport importformedit = new formEimport();
            importformedit.ShowDialog();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAexport exportformadd = new formAexport();
            exportformadd.ShowDialog();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEexport exportformedit = new formEexport();
            exportformedit.ShowDialog();
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAshop formAshop = new formAshop();
            formAshop.ShowDialog();
        }

        private void editShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEshop formEshop = new formEshop();
            formEshop.ShowDialog();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formAuser formAuser = new formAuser();
            formAuser.ShowDialog();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRuser formRuser = new formRuser();
            formRuser.ShowDialog();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCP formCP = new formCP();
            formCP.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMain formMain = new formMain();
            formMain.ShowDialog();
        }
    }
}
