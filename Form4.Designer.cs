namespace FP
{
    partial class formSproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalViewerSP1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalViewerSP1
            // 
            this.crystalViewerSP1.ActiveViewIndex = -1;
            this.crystalViewerSP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewerSP1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewerSP1.DisplayBackgroundEdge = false;
            this.crystalViewerSP1.DisplayStatusBar = false;
            this.crystalViewerSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalViewerSP1.Location = new System.Drawing.Point(0, 0);
            this.crystalViewerSP1.Name = "crystalViewerSP1";
            this.crystalViewerSP1.ShowCloseButton = false;
            this.crystalViewerSP1.ShowCopyButton = false;
            this.crystalViewerSP1.ShowExportButton = false;
            this.crystalViewerSP1.ShowGotoPageButton = false;
            this.crystalViewerSP1.ShowGroupTreeButton = false;
            this.crystalViewerSP1.ShowLogo = false;
            this.crystalViewerSP1.ShowPageNavigateButtons = false;
            this.crystalViewerSP1.ShowParameterPanelButton = false;
            this.crystalViewerSP1.ShowTextSearchButton = false;
            this.crystalViewerSP1.ShowZoomButton = false;
            this.crystalViewerSP1.Size = new System.Drawing.Size(800, 450);
            this.crystalViewerSP1.TabIndex = 0;
            this.crystalViewerSP1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productReportToolStripMenuItem,
            this.damageReportToolStripMenuItem,
            this.importReportToolStripMenuItem,
            this.exportReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // productReportToolStripMenuItem
            // 
            this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
            this.productReportToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.productReportToolStripMenuItem.Text = "Product Search";
            this.productReportToolStripMenuItem.Click += new System.EventHandler(this.productReportToolStripMenuItem_Click);
            // 
            // damageReportToolStripMenuItem
            // 
            this.damageReportToolStripMenuItem.Name = "damageReportToolStripMenuItem";
            this.damageReportToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.damageReportToolStripMenuItem.Text = "Damage Report";
            this.damageReportToolStripMenuItem.Click += new System.EventHandler(this.damageReportToolStripMenuItem_Click);
            // 
            // importReportToolStripMenuItem
            // 
            this.importReportToolStripMenuItem.Name = "importReportToolStripMenuItem";
            this.importReportToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.importReportToolStripMenuItem.Text = "Import Report";
            this.importReportToolStripMenuItem.Click += new System.EventHandler(this.importReportToolStripMenuItem_Click);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            this.exportReportToolStripMenuItem.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductToolStripMenuItem,
            this.toolStripMenuItem1,
            this.manageShopsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductToolStripMenuItem});
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            // 
            // manageShopsToolStripMenuItem
            // 
            this.manageShopsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShopToolStripMenuItem,
            this.editShopToolStripMenuItem});
            this.manageShopsToolStripMenuItem.Name = "manageShopsToolStripMenuItem";
            this.manageShopsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageShopsToolStripMenuItem.Text = "Manage Shops";
            // 
            // addShopToolStripMenuItem
            // 
            this.addShopToolStripMenuItem.Name = "addShopToolStripMenuItem";
            this.addShopToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.addShopToolStripMenuItem.Text = "Add Shop";
            // 
            // editShopToolStripMenuItem
            // 
            this.editShopToolStripMenuItem.Name = "editShopToolStripMenuItem";
            this.editShopToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.editShopToolStripMenuItem.Text = "Edit Shop";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.manageUsersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.changeToolStripMenuItem.Text = "Change Credentials";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Trade";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importProductToolStripMenuItem,
            this.editToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Import";
            // 
            // importProductToolStripMenuItem
            // 
            this.importProductToolStripMenuItem.Name = "importProductToolStripMenuItem";
            this.importProductToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.importProductToolStripMenuItem.Text = "Add Record";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.editToolStripMenuItem.Text = "Edit Record";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem3.Text = "Export";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.editRecordToolStripMenuItem.Text = "Edit Record";
            // 
            // formSproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalViewerSP1);
            this.Name = "formSproduct";
            this.Text = "Advance Product Report";
            this.Load += new System.EventHandler(this.formSproduct_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FP.CrystalReportSP CrystalReportSP1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewerSP1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
    }
}