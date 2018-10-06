namespace SalaryCounting.EditForms
{
    partial class DepartmentForm
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
            this.numberTbx = new System.Windows.Forms.TextBox();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTbx
            // 
            this.numberTbx.Location = new System.Drawing.Point(104, 38);
            this.numberTbx.MaxLength = 31;
            this.numberTbx.Name = "numberTbx";
            this.numberTbx.Size = new System.Drawing.Size(100, 20);
            this.numberTbx.TabIndex = 0;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(104, 65);
            this.nameTbx.MaxLength = 63;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(100, 20);
            this.nameTbx.TabIndex = 1;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(57, 41);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(41, 13);
            this.numberLbl.TabIndex = 2;
            this.numberLbl.Text = "Номер";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(41, 68);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 13);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Название";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(82, 111);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 157);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.numberTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.Text = "Отдел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTbx;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button okBtn;
    }
}