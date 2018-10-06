namespace SalaryCounting.EditForms
{
    partial class ProductStandartsForm
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
            this.productCbx = new System.Windows.Forms.ComboBox();
            this.productLbl = new System.Windows.Forms.Label();
            this.dataGridOperations = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okBtn = new System.Windows.Forms.Button();
            this.addStandartBtn = new System.Windows.Forms.Button();
            this.editStandartBtn = new System.Windows.Forms.Button();
            this.deleteStandartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // departCbx
            // 
            this.departCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCbx.FormattingEnabled = true;
            this.departCbx.Location = new System.Drawing.Point(158, 23);
            this.departCbx.Name = "departCbx";
            this.departCbx.Size = new System.Drawing.Size(200, 21);
            this.departCbx.TabIndex = 5;
            this.departCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // departLbl
            // 
            this.departLbl.AutoSize = true;
            this.departLbl.Location = new System.Drawing.Point(102, 26);
            this.departLbl.Name = "departLbl";
            this.departLbl.Size = new System.Drawing.Size(38, 13);
            this.departLbl.TabIndex = 4;
            this.departLbl.Text = "Отдел";
            // 
            // productCbx
            // 
            this.productCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCbx.FormattingEnabled = true;
            this.productCbx.Location = new System.Drawing.Point(158, 50);
            this.productCbx.Name = "productCbx";
            this.productCbx.Size = new System.Drawing.Size(200, 21);
            this.productCbx.TabIndex = 7;
            this.productCbx.SelectedIndexChanged += new System.EventHandler(this.departCbx_SelectedIndexChanged);
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(89, 53);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(51, 13);
            this.productLbl.TabIndex = 6;
            this.productLbl.Text = "Изделие";
            // 
            // dataGridOperations
            // 
            this.dataGridOperations.AllowUserToAddRows = false;
            this.dataGridOperations.AllowUserToDeleteRows = false;
            this.dataGridOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.standart,
            this.price});
            this.dataGridOperations.Location = new System.Drawing.Point(1, 116);
            this.dataGridOperations.MultiSelect = false;
            this.dataGridOperations.Name = "dataGridOperations";
            this.dataGridOperations.ReadOnly = true;
            this.dataGridOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOperations.Size = new System.Drawing.Size(451, 243);
            this.dataGridOperations.TabIndex = 8;
            this.dataGridOperations.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridOperations_CellValidating);
            this.dataGridOperations.DoubleClick += new System.EventHandler(this.editStandartBtn_Click);
            this.dataGridOperations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridOperations_KeyPress);
            // 
            // name
            // 
            this.name.HeaderText = "Название операции";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // standart
            // 
            this.standart.HeaderText = "Норма";
            this.standart.Name = "standart";
            this.standart.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Расценка";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.Location = new System.Drawing.Point(0, 364);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(455, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // addStandartBtn
            // 
            this.addStandartBtn.Location = new System.Drawing.Point(13, 87);
            this.addStandartBtn.Name = "addStandartBtn";
            this.addStandartBtn.Size = new System.Drawing.Size(75, 23);
            this.addStandartBtn.TabIndex = 10;
            this.addStandartBtn.Text = "Добавить";
            this.addStandartBtn.UseVisualStyleBackColor = true;
            this.addStandartBtn.Click += new System.EventHandler(this.addStandartBtn_Click);
            // 
            // editStandartBtn
            // 
            this.editStandartBtn.Location = new System.Drawing.Point(94, 87);
            this.editStandartBtn.Name = "editStandartBtn";
            this.editStandartBtn.Size = new System.Drawing.Size(95, 23);
            this.editStandartBtn.TabIndex = 11;
            this.editStandartBtn.Text = "Редактировать";
            this.editStandartBtn.UseVisualStyleBackColor = true;
            this.editStandartBtn.Click += new System.EventHandler(this.editStandartBtn_Click);
            // 
            // deleteStandartBtn
            // 
            this.deleteStandartBtn.Location = new System.Drawing.Point(195, 87);
            this.deleteStandartBtn.Name = "deleteStandartBtn";
            this.deleteStandartBtn.Size = new System.Drawing.Size(74, 23);
            this.deleteStandartBtn.TabIndex = 12;
            this.deleteStandartBtn.Text = "Удалить";
            this.deleteStandartBtn.UseVisualStyleBackColor = true;
            this.deleteStandartBtn.Click += new System.EventHandler(this.deleteStandartBtn_Click);
            // 
            // ProductStandartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 387);
            this.Controls.Add(this.deleteStandartBtn);
            this.Controls.Add(this.editStandartBtn);
            this.Controls.Add(this.addStandartBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.dataGridOperations);
            this.Controls.Add(this.productCbx);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.departCbx);
            this.Controls.Add(this.departLbl);
            this.Name = "ProductStandartsForm";
            this.Text = "Норма выработки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departCbx;
        private System.Windows.Forms.Label departLbl;
        private System.Windows.Forms.ComboBox productCbx;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.DataGridView dataGridOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn standart;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button addStandartBtn;
        private System.Windows.Forms.Button editStandartBtn;
        private System.Windows.Forms.Button deleteStandartBtn;
    }
}