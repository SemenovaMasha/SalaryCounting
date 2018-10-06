namespace SalaryCounting.EditForms
{
    partial class ProductsSheetForm
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
            this.datePck = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.departLbl = new System.Windows.Forms.Label();
            this.departCbx = new System.Windows.Forms.ComboBox();
            this.operations_table = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operations_table)).BeginInit();
            this.SuspendLayout();
            // 
            // datePck
            // 
            this.datePck.Location = new System.Drawing.Point(206, 23);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(200, 20);
            this.datePck.TabIndex = 0;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(155, 26);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Дата";
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Location = new System.Drawing.Point(150, 56);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(38, 13);
            this.departLbl.TabIndex = 2;
            this.departLbl.Text = "Отдел";
            // 
            // departCbx
            // 
            this.departCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCbx.FormattingEnabled = true;
            this.departCbx.Location = new System.Drawing.Point(206, 53);
            this.departCbx.Name = "departCbx";
            this.departCbx.Size = new System.Drawing.Size(200, 21);
            this.departCbx.TabIndex = 3;
            this.departCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // operations_table
            // 
            this.operations_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operations_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operations_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operations_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee,
            this.product,
            this.operation,
            this.count});
            this.operations_table.Location = new System.Drawing.Point(2, 94);
            this.operations_table.Name = "operations_table";
            this.operations_table.Size = new System.Drawing.Size(612, 310);
            this.operations_table.TabIndex = 4;
            this.operations_table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.operations_table_CellEndEdit);
            this.operations_table.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.operations_table_CellValidating);
            this.operations_table.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.operations_table_DataError);
            // 
            // employee
            // 
            this.employee.HeaderText = "Сотрудник";
            this.employee.Name = "employee";
            this.employee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // product
            // 
            this.product.HeaderText = "Изделие";
            this.product.Name = "product";
            // 
            // operation
            // 
            this.operation.HeaderText = "Операция";
            this.operation.Name = "operation";
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.Location = new System.Drawing.Point(0, 411);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(615, 24);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ProductsSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 435);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.operations_table);
            this.Controls.Add(this.departCbx);
            this.Controls.Add(this.departLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.datePck);
            this.Name = "ProductsSheetForm";
            this.Text = "Ведомость по нормам выработки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.operations_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePck;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.ComboBox departCbx;
        private System.Windows.Forms.DataGridView operations_table;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employee;
        private System.Windows.Forms.DataGridViewComboBoxColumn product;
        private System.Windows.Forms.DataGridViewComboBoxColumn operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
}