namespace SalaryCounting.EditForms
{
    partial class PaySheetForm
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
            this.dataGridSheet = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filTableBtn = new System.Windows.Forms.Button();
            this.departCbx = new System.Windows.Forms.ComboBox();
            this.departLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.datePck = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.savePaySheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.Location = new System.Drawing.Point(0, 420);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(755, 24);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // dataGridSheet
            // 
            this.dataGridSheet.AllowUserToAddRows = false;
            this.dataGridSheet.AllowUserToDeleteRows = false;
            this.dataGridSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.sum});
            this.dataGridSheet.Location = new System.Drawing.Point(1, 62);
            this.dataGridSheet.Name = "dataGridSheet";
            this.dataGridSheet.ReadOnly = true;
            this.dataGridSheet.Size = new System.Drawing.Size(754, 352);
            this.dataGridSheet.TabIndex = 17;
            this.dataGridSheet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridSheet_DataError);
            // 
            // employee
            // 
            this.employee.HeaderText = "Сотрудник";
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // filTableBtn
            // 
            this.filTableBtn.Location = new System.Drawing.Point(440, 8);
            this.filTableBtn.Name = "filTableBtn";
            this.filTableBtn.Size = new System.Drawing.Size(143, 43);
            this.filTableBtn.TabIndex = 19;
            this.filTableBtn.Text = "Заполнить";
            this.filTableBtn.UseVisualStyleBackColor = true;
            this.filTableBtn.Click += new System.EventHandler(this.filTableBtn_Click);
            // 
            // departCbx
            // 
            this.departCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCbx.FormattingEnabled = true;
            this.departCbx.Location = new System.Drawing.Point(200, 35);
            this.departCbx.Name = "departCbx";
            this.departCbx.Size = new System.Drawing.Size(200, 21);
            this.departCbx.TabIndex = 16;
            this.departCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Location = new System.Drawing.Point(144, 38);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(38, 13);
            this.departLbl.TabIndex = 15;
            this.departLbl.Text = "Отдел";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(149, 8);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 14;
            this.dateLbl.Text = "Дата";
            // 
            // datePck
            // 
            this.datePck.Location = new System.Drawing.Point(200, 5);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(200, 20);
            this.datePck.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(590, 8);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 43);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // PaySheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 444);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dataGridSheet);
            this.Controls.Add(this.filTableBtn);
            this.Controls.Add(this.departCbx);
            this.Controls.Add(this.departLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.datePck);
            this.Name = "PaySheetForm";
            this.Text = "Ведомость выплаты зарплаты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridView dataGridSheet;
        private System.Windows.Forms.Button filTableBtn;
        private System.Windows.Forms.ComboBox departCbx;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker datePck;
        private System.Windows.Forms.DataGridViewComboBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog savePaySheetFileDialog;
    }
}