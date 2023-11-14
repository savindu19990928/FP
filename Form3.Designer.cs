namespace FP
{
    partial class formSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.ComboBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearch.FormattingEnabled = true;
            this.txtSearch.Location = new System.Drawing.Point(204, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 24);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.SelectionChangeCommitted += new System.EventHandler(this.txtSearch_SelectionChangeCommitted);
            this.txtSearch.DropDownClosed += new System.EventHandler(this.txtSearch_DropDownClosed);
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(204, 53);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(250, 27);
            this.searchBar.TabIndex = 4;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // formSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.txtSearch);
            this.Name = "formSearch";
            this.Text = "Search Product";
            this.Load += new System.EventHandler(this.formSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtSearch;
        private System.Windows.Forms.TextBox searchBar;
    }
}