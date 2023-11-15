namespace FP
{
    partial class addProduct
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
            this.aptxt = new System.Windows.Forms.TextBox();
            this.addPbtn = new System.Windows.Forms.Button();
            this.cancelBtnAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product name";
            // 
            // aptxt
            // 
            this.aptxt.Location = new System.Drawing.Point(259, 67);
            this.aptxt.Name = "aptxt";
            this.aptxt.Size = new System.Drawing.Size(169, 22);
            this.aptxt.TabIndex = 4;
            this.aptxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aptxt_KeyPress);
            // 
            // addPbtn
            // 
            this.addPbtn.Location = new System.Drawing.Point(259, 154);
            this.addPbtn.Name = "addPbtn";
            this.addPbtn.Size = new System.Drawing.Size(169, 38);
            this.addPbtn.TabIndex = 5;
            this.addPbtn.Text = "Add";
            this.addPbtn.UseVisualStyleBackColor = true;
            this.addPbtn.Click += new System.EventHandler(this.addPbtn_Click);
            // 
            // cancelBtnAP
            // 
            this.cancelBtnAP.Location = new System.Drawing.Point(51, 154);
            this.cancelBtnAP.Name = "cancelBtnAP";
            this.cancelBtnAP.Size = new System.Drawing.Size(169, 38);
            this.cancelBtnAP.TabIndex = 6;
            this.cancelBtnAP.Text = "Cancel";
            this.cancelBtnAP.UseVisualStyleBackColor = true;
            this.cancelBtnAP.Click += new System.EventHandler(this.cancelBtnAP_Click);
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 233);
            this.Controls.Add(this.cancelBtnAP);
            this.Controls.Add(this.addPbtn);
            this.Controls.Add(this.aptxt);
            this.Controls.Add(this.label1);
            this.Name = "addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aptxt;
        private System.Windows.Forms.Button addPbtn;
        private System.Windows.Forms.Button cancelBtnAP;
    }
}