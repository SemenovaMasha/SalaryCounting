namespace SalaryCounting.EditForms
{
    partial class ProductForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.numberTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(84, 97);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(43, 54);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Название";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(52, 27);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(48, 13);
            this.numberLbl.TabIndex = 7;
            this.numberLbl.Text = "Артикул";
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(106, 51);
            this.nameTbx.MaxLength = 63;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(100, 20);
            this.nameTbx.TabIndex = 6;
            // 
            // numberTbx
            // 
            this.numberTbx.Location = new System.Drawing.Point(106, 24);
            this.numberTbx.MaxLength = 31;
            this.numberTbx.Name = "numberTbx";
            this.numberTbx.Size = new System.Drawing.Size(100, 20);
            this.numberTbx.TabIndex = 5;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 137);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.numberTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.Text = "Изделие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox numberTbx;
    }
}