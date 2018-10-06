namespace SalaryCounting.EditForms
{
    partial class EmployeeForm
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
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.secondNameLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.firstNameTbx = new System.Windows.Forms.TextBox();
            this.secondNameTbx = new System.Windows.Forms.TextBox();
            this.departmentCbx = new System.Windows.Forms.ComboBox();
            this.tableNumberTbx = new System.Windows.Forms.TextBox();
            this.tableNumberLbl = new System.Windows.Forms.Label();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.middleNameTbx = new System.Windows.Forms.TextBox();
            this.salaryTbx = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(85, 56);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(29, 13);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "Имя";
            // 
            // secondNameLbl
            // 
            this.secondNameLbl.AutoSize = true;
            this.secondNameLbl.Location = new System.Drawing.Point(58, 82);
            this.secondNameLbl.Name = "secondNameLbl";
            this.secondNameLbl.Size = new System.Drawing.Size(56, 13);
            this.secondNameLbl.TabIndex = 1;
            this.secondNameLbl.Text = "Фамилия";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Location = new System.Drawing.Point(76, 135);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(39, 13);
            this.salaryLbl.TabIndex = 2;
            this.salaryLbl.Text = "Оклад";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(76, 161);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(38, 13);
            this.departmentLbl.TabIndex = 3;
            this.departmentLbl.Text = "Отдел";
            // 
            // firstNameTbx
            // 
            this.firstNameTbx.Location = new System.Drawing.Point(120, 53);
            this.firstNameTbx.MaxLength = 31;
            this.firstNameTbx.Name = "firstNameTbx";
            this.firstNameTbx.Size = new System.Drawing.Size(122, 20);
            this.firstNameTbx.TabIndex = 2;
            // 
            // secondNameTbx
            // 
            this.secondNameTbx.Location = new System.Drawing.Point(120, 80);
            this.secondNameTbx.MaxLength = 63;
            this.secondNameTbx.Name = "secondNameTbx";
            this.secondNameTbx.Size = new System.Drawing.Size(122, 20);
            this.secondNameTbx.TabIndex = 3;
            // 
            // departmentCbx
            // 
            this.departmentCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCbx.FormattingEnabled = true;
            this.departmentCbx.Location = new System.Drawing.Point(120, 158);
            this.departmentCbx.Name = "departmentCbx";
            this.departmentCbx.Size = new System.Drawing.Size(122, 21);
            this.departmentCbx.TabIndex = 6;
            // 
            // tableNumberTbx
            // 
            this.tableNumberTbx.Location = new System.Drawing.Point(120, 27);
            this.tableNumberTbx.MaxLength = 31;
            this.tableNumberTbx.Name = "tableNumberTbx";
            this.tableNumberTbx.Size = new System.Drawing.Size(122, 20);
            this.tableNumberTbx.TabIndex = 1;
            // 
            // tableNumberLbl
            // 
            this.tableNumberLbl.AutoSize = true;
            this.tableNumberLbl.Location = new System.Drawing.Point(16, 30);
            this.tableNumberLbl.Name = "tableNumberLbl";
            this.tableNumberLbl.Size = new System.Drawing.Size(99, 13);
            this.tableNumberLbl.TabIndex = 8;
            this.tableNumberLbl.Text = "Табельный номер";
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Location = new System.Drawing.Point(61, 109);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(54, 13);
            this.middleNameLbl.TabIndex = 10;
            this.middleNameLbl.Text = "Отчество";
            // 
            // middleNameTbx
            // 
            this.middleNameTbx.Location = new System.Drawing.Point(120, 106);
            this.middleNameTbx.MaxLength = 63;
            this.middleNameTbx.Name = "middleNameTbx";
            this.middleNameTbx.Size = new System.Drawing.Size(122, 20);
            this.middleNameTbx.TabIndex = 4;
            // 
            // salaryTbx
            // 
            this.salaryTbx.Location = new System.Drawing.Point(120, 132);
            this.salaryTbx.MaxLength = 18;
            this.salaryTbx.Name = "salaryTbx";
            this.salaryTbx.Size = new System.Drawing.Size(122, 20);
            this.salaryTbx.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(97, 199);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 246);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.salaryTbx);
            this.Controls.Add(this.middleNameTbx);
            this.Controls.Add(this.middleNameLbl);
            this.Controls.Add(this.tableNumberTbx);
            this.Controls.Add(this.tableNumberLbl);
            this.Controls.Add(this.departmentCbx);
            this.Controls.Add(this.secondNameTbx);
            this.Controls.Add(this.firstNameTbx);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.secondNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Text = "Сотрудник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label secondNameLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.TextBox firstNameTbx;
        private System.Windows.Forms.TextBox secondNameTbx;
        private System.Windows.Forms.ComboBox departmentCbx;
        private System.Windows.Forms.TextBox tableNumberTbx;
        private System.Windows.Forms.Label tableNumberLbl;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.TextBox middleNameTbx;
        private System.Windows.Forms.TextBox salaryTbx;
        private System.Windows.Forms.Button okBtn;
    }
}