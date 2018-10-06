namespace SalaryCounting.EditForms
{
    partial class ProductionStandartForm
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
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.standartTbx = new System.Windows.Forms.TextBox();
            this.priceTbx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.standartLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(131, 21);
            this.nameTbx.MaxLength = 63;
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(100, 20);
            this.nameTbx.TabIndex = 0;
            // 
            // standartTbx
            // 
            this.standartTbx.Location = new System.Drawing.Point(131, 48);
            this.standartTbx.MaxLength = 15;
            this.standartTbx.Name = "standartTbx";
            this.standartTbx.Size = new System.Drawing.Size(100, 20);
            this.standartTbx.TabIndex = 1;
            // 
            // priceTbx
            // 
            this.priceTbx.Location = new System.Drawing.Point(131, 75);
            this.priceTbx.MaxLength = 18;
            this.priceTbx.Name = "priceTbx";
            this.priceTbx.Size = new System.Drawing.Size(100, 20);
            this.priceTbx.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(68, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 13);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Название";
            // 
            // standartLbl
            // 
            this.standartLbl.AutoSize = true;
            this.standartLbl.Location = new System.Drawing.Point(84, 51);
            this.standartLbl.Name = "standartLbl";
            this.standartLbl.Size = new System.Drawing.Size(41, 13);
            this.standartLbl.TabIndex = 4;
            this.standartLbl.Text = "Норма";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(68, 78);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(56, 13);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Расценка";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(87, 114);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ProductionStandartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 159);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.standartLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.priceTbx);
            this.Controls.Add(this.standartTbx);
            this.Controls.Add(this.nameTbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProductionStandartForm";
            this.Text = "Операция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox standartTbx;
        private System.Windows.Forms.TextBox priceTbx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label standartLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button okBtn;
    }
}