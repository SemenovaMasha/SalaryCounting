namespace SalaryCounting.EditForms
{
    partial class EmployeesPaySheetForm
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
            this.departCbx = new System.Windows.Forms.ComboBox();
            this.departLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.datePck = new System.Windows.Forms.DateTimePicker();
            this.employeeCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settlePlusLbl = new System.Windows.Forms.Label();
            this.dataGridPlus = new System.Windows.Forms.DataGridView();
            this.settle_type_plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridMinus = new System.Windows.Forms.DataGridView();
            this.settle_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settleMinusLbl = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.allSumLbl = new System.Windows.Forms.Label();
            this.countBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.savePaySheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // departCbx
            // 
            this.departCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCbx.FormattingEnabled = true;
            this.departCbx.Location = new System.Drawing.Point(178, 54);
            this.departCbx.Name = "departCbx";
            this.departCbx.Size = new System.Drawing.Size(200, 21);
            this.departCbx.TabIndex = 13;
            this.departCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Location = new System.Drawing.Point(122, 57);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(38, 13);
            this.departLbl.TabIndex = 12;
            this.departLbl.Text = "Отдел";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(127, 27);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 11;
            this.dateLbl.Text = "Дата";
            // 
            // datePck
            // 
            this.datePck.Location = new System.Drawing.Point(178, 24);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(200, 20);
            this.datePck.TabIndex = 10;
            // 
            // employeeCbx
            // 
            this.employeeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCbx.FormattingEnabled = true;
            this.employeeCbx.Location = new System.Drawing.Point(178, 81);
            this.employeeCbx.Name = "employeeCbx";
            this.employeeCbx.Size = new System.Drawing.Size(200, 21);
            this.employeeCbx.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Сотрудник";
            // 
            // settlePlusLbl
            // 
            this.settlePlusLbl.AutoSize = true;
            this.settlePlusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settlePlusLbl.Location = new System.Drawing.Point(13, 131);
            this.settlePlusLbl.Name = "settlePlusLbl";
            this.settlePlusLbl.Size = new System.Drawing.Size(82, 13);
            this.settlePlusLbl.TabIndex = 16;
            this.settlePlusLbl.Text = "Начисления:";
            // 
            // dataGridPlus
            // 
            this.dataGridPlus.AllowUserToAddRows = false;
            this.dataGridPlus.AllowUserToDeleteRows = false;
            this.dataGridPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPlus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPlus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settle_type_plus,
            this.value_plus});
            this.dataGridPlus.Location = new System.Drawing.Point(12, 157);
            this.dataGridPlus.Name = "dataGridPlus";
            this.dataGridPlus.ReadOnly = true;
            this.dataGridPlus.Size = new System.Drawing.Size(534, 158);
            this.dataGridPlus.TabIndex = 17;
            // 
            // settle_type_plus
            // 
            this.settle_type_plus.HeaderText = "Вид начисления";
            this.settle_type_plus.Name = "settle_type_plus";
            this.settle_type_plus.ReadOnly = true;
            // 
            // value_plus
            // 
            this.value_plus.HeaderText = "Сумма";
            this.value_plus.Name = "value_plus";
            this.value_plus.ReadOnly = true;
            // 
            // dataGridMinus
            // 
            this.dataGridMinus.AllowUserToAddRows = false;
            this.dataGridMinus.AllowUserToDeleteRows = false;
            this.dataGridMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMinus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMinus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMinus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.settle_type,
            this.value});
            this.dataGridMinus.Location = new System.Drawing.Point(16, 355);
            this.dataGridMinus.Name = "dataGridMinus";
            this.dataGridMinus.ReadOnly = true;
            this.dataGridMinus.Size = new System.Drawing.Size(534, 162);
            this.dataGridMinus.TabIndex = 19;
            // 
            // settle_type
            // 
            this.settle_type.HeaderText = "Вид удержания";
            this.settle_type.Name = "settle_type";
            this.settle_type.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Сумма";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // settleMinusLbl
            // 
            this.settleMinusLbl.AutoSize = true;
            this.settleMinusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settleMinusLbl.Location = new System.Drawing.Point(17, 329);
            this.settleMinusLbl.Name = "settleMinusLbl";
            this.settleMinusLbl.Size = new System.Drawing.Size(78, 13);
            this.settleMinusLbl.TabIndex = 18;
            this.settleMinusLbl.Text = "Удержания:";
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLbl.Location = new System.Drawing.Point(17, 528);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(46, 13);
            this.sumLbl.TabIndex = 20;
            this.sumLbl.Text = "Итого:";
            // 
            // allSumLbl
            // 
            this.allSumLbl.AutoSize = true;
            this.allSumLbl.Location = new System.Drawing.Point(69, 528);
            this.allSumLbl.Name = "allSumLbl";
            this.allSumLbl.Size = new System.Drawing.Size(13, 13);
            this.allSumLbl.TabIndex = 21;
            this.allSumLbl.Text = "0";
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(151, 554);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(94, 25);
            this.countBtn.TabIndex = 22;
            this.countBtn.Text = "Рассчитать";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(312, 554);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(92, 25);
            this.printBtn.TabIndex = 23;
            this.printBtn.Text = "Сохранить";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // savePaySheetFileDialog
            // 
            this.savePaySheetFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // EmployeesPaySheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 593);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.allSumLbl);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.dataGridMinus);
            this.Controls.Add(this.settleMinusLbl);
            this.Controls.Add(this.dataGridPlus);
            this.Controls.Add(this.settlePlusLbl);
            this.Controls.Add(this.employeeCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departCbx);
            this.Controls.Add(this.departLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.datePck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeesPaySheetForm";
            this.Text = "Расчетный лист сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departCbx;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker datePck;
        private System.Windows.Forms.ComboBox employeeCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label settlePlusLbl;
        private System.Windows.Forms.DataGridView dataGridPlus;
        private System.Windows.Forms.DataGridView dataGridMinus;
        private System.Windows.Forms.Label settleMinusLbl;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label allSumLbl;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settle_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn settle_type_plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_plus;
        private System.Windows.Forms.SaveFileDialog savePaySheetFileDialog;
        private System.Windows.Forms.FolderBrowserDialog saveFolderBrowserDialog;
    }
}