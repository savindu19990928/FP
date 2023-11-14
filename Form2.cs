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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSearch formSearch = new formSearch();
            formSearch.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void damageReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDmg formDmg = new formDmg();
            formDmg.Show();
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

        private void formMain_Load(object sender, EventArgs e)
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
            reportDocument.Load(Path.Combine(path, "CrystalReportAP1.rpt"));

            crystalReportViewer2.ReportSource = reportDocument;
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
    }
}
