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
            formSearch.Show();
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
