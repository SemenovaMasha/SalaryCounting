namespace SalaryCounting.EditForms
{
    partial class SettlementForm
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
            this.sizeTbx = new System.Windows.Forms.TextBox();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.secondNameLbl = new System.Windows.Forms.Label();
            this.fixedChbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(101, 140);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // sizeTbx
            // 
            this.sizeTbx.Location = new System.Drawing.Point(145, 102);
            this.sizeTbx.MaxLength = 63;
            this.sizeTbx.Name = "sizeTbx";
            this.sizeTbx.Size = new System.Drawing.Size(122, 20);
            this.sizeTbx.TabIndex = 15;
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Location = new System.Drawing.Point(113, 53);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(26, 13);
            this.middleNameLbl.TabIndex = 19;
            this.middleNameLbl.Text = "Тип";
            // 
            // typeCbx
            // 
            this.typeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCbx.FormattingEnabled = true;
            this.typeCbx.Location = new System.Drawing.Point(145, 50);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(122, 21);
            this.typeCbx.TabIndex = 17;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(145, 24);
            this.nameTbx.MaxLength = 63;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(122, 20);
            this.nameTbx.TabIndex = 13;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(28, 105);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(111, 13);
            this.departmentLbl.TabIndex = 14;
            this.departmentLbl.Text = "Размер или процент";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Location = new System.Drawing.Point(15, 79);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(124, 13);
            this.salaryLbl.TabIndex = 12;
            this.salaryLbl.Text = "Сумма фиксированная";
            // 
            // secondNameLbl
            // 
            this.secondNameLbl.AutoSize = true;
            this.secondNameLbl.Location = new System.Drawing.Point(56, 27);
            this.secondNameLbl.Name = "secondNameLbl";
            this.secondNameLbl.Size = new System.Drawing.Size(83, 13);
            this.secondNameLbl.TabIndex = 11;
            this.secondNameLbl.Text = "Наименование";
            // 
            // fixedChbx
            // 
            this.fixedChbx.AutoSize = true;
            this.fixedChbx.Location = new System.Drawing.Point(145, 79);
            this.fixedChbx.Name = "fixedChbx";
            this.fixedChbx.Size = new System.Drawing.Size(15, 14);
            this.fixedChbx.TabIndex = 20;
            this.fixedChbx.UseVisualStyleBackColor = true;
            // 
            // SettlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 188);
            this.Controls.Add(this.fixedChbx);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.sizeTbx);
            this.Controls.Add(this.middleNameLbl);
            this.Controls.Add(this.typeCbx);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.secondNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettlementForm";
            this.Text = "Вид расчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox sizeTbx;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label secondNameLbl;
        private System.Windows.Forms.CheckBox fixedChbx;
    }
}