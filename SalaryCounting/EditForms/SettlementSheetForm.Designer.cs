namespace SalaryCounting.EditForms
{
    partial class SettlementSheetForm
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
            this.settle_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departCbx = new System.Windows.Forms.ComboBox();
            this.departLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.datePck = new System.Windows.Forms.DateTimePicker();
            this.filTableBtn = new System.Windows.Forms.Button();
            this.recountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.Location = new System.Drawing.Point(0, 381);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(618, 24);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // dataGridSheet
            // 
            this.dataGridSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.settle_type,
            this.value});
            this.dataGridSheet.Location = new System.Drawing.Point(1, 67);
            this.dataGridSheet.Name = "dataGridSheet";
            this.dataGridSheet.Size = new System.Drawing.Size(612, 306);
            this.dataGridSheet.TabIndex = 10;
            this.dataGridSheet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSheet_CellEndEdit);
            this.dataGridSheet.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridSheet_CellValidating);
            this.dataGridSheet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridSheet_DataError);
            // 
            // employee
            // 
            this.employee.HeaderText = "Сотрудник";
            this.employee.Name = "employee";
            this.employee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // settle_type
            // 
            this.settle_type.HeaderText = "Вид расчета";
            this.settle_type.Name = "settle_type";
            // 
            // value
            // 
            this.value.HeaderText = "Сумма или процент";
            this.value.Name = "value";
            // 
            // departCbx
            // 
            this.departCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCbx.FormattingEnabled = true;
            this.departCbx.Location = new System.Drawing.Point(200, 40);
            this.departCbx.Name = "departCbx";
            this.departCbx.Size = new System.Drawing.Size(200, 21);
            this.departCbx.TabIndex = 9;
            this.departCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Location = new System.Drawing.Point(144, 43);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(38, 13);
            this.departLbl.TabIndex = 8;
            this.departLbl.Text = "Отдел";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(149, 13);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 7;
            this.dateLbl.Text = "Дата";
            // 
            // datePck
            // 
            this.datePck.Location = new System.Drawing.Point(200, 10);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(200, 20);
            this.datePck.TabIndex = 6;
            // 
            // filTableBtn
            // 
            this.filTableBtn.Location = new System.Drawing.Point(406, 10);
            this.filTableBtn.Name = "filTableBtn";
            this.filTableBtn.Size = new System.Drawing.Size(85, 51);
            this.filTableBtn.TabIndex = 12;
            this.filTableBtn.Text = "Заполнить";
            this.filTableBtn.UseVisualStyleBackColor = true;
            this.filTableBtn.Click += new System.EventHandler(this.filTableBtn_Click);
            // 
            // recountBtn
            // 
            this.recountBtn.Location = new System.Drawing.Point(497, 10);
            this.recountBtn.Name = "recountBtn";
            this.recountBtn.Size = new System.Drawing.Size(109, 51);
            this.recountBtn.TabIndex = 13;
            this.recountBtn.Text = "Пересчитать оклад и нормы выработки";
            this.recountBtn.UseVisualStyleBackColor = true;
            this.recountBtn.Visible = false;
            this.recountBtn.Click += new System.EventHandler(this.recountBtn_Click);
            // 
            // SettlementSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 405);
            this.Controls.Add(this.recountBtn);
            this.Controls.Add(this.filTableBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dataGridSheet);
            this.Controls.Add(this.departCbx);
            this.Controls.Add(this.departLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.datePck);
            this.Name = "SettlementSheetForm";
            this.Text = "Ведомость начислений и удержаний";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridView dataGridSheet;
        private System.Windows.Forms.ComboBox departCbx;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker datePck;
        private System.Windows.Forms.DataGridViewComboBoxColumn employee;
        private System.Windows.Forms.DataGridViewComboBoxColumn settle_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button filTableBtn;
        private System.Windows.Forms.Button recountBtn;
    }
}