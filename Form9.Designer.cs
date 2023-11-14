namespace FP
{
    partial class formEproduct
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
            this.txtNname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboP = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Product";
            // 
            // txtNname
            // 
            this.txtNname.Location = new System.Drawing.Point(241, 141);
            this.txtNname.Name = "txtNname";
            this.txtNname.Size = new System.Drawing.Size(179, 22);
            this.txtNname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // comboP
            // 
            this.comboP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboP.FormattingEnabled = true;
            this.comboP.Location = new System.Drawing.Point(241, 58);
            this.comboP.Name = "comboP";
            this.comboP.Size = new System.Drawing.Size(179, 24);
            this.comboP.TabIndex = 3;
            this.comboP.SelectionChangeCommitted += new System.EventHandler(this.comboP_SelectionChangeCommitted);
            this.comboP.DropDownClosed += new System.EventHandler(this.comboP_DropDownClosed);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Delete";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(241, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 27);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // formEproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 288);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNname);
            this.Controls.Add(this.label1);
            this.Name = "formEproduct";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.formEproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
    }
}