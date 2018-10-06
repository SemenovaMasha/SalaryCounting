namespace SalaryCounting
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.handbooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settlementSheetОРасчетахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productStandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePaySheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paySheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handbooksToolStripMenuItem,
            this.ведомостиToolStripMenuItem,
            this.countingToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // handbooksToolStripMenuItem
            // 
            this.handbooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.departToolStripMenuItem,
            this.productToolStripMenuItem,
            this.settlementToolStripMenuItem});
            this.handbooksToolStripMenuItem.Name = "handbooksToolStripMenuItem";
            this.handbooksToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.handbooksToolStripMenuItem.Text = "Справочники";
            this.handbooksToolStripMenuItem.Click += new System.EventHandler(this.handbooksToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.employeeToolStripMenuItem.Text = "Сотрудники";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // departToolStripMenuItem
            // 
            this.departToolStripMenuItem.Name = "departToolStripMenuItem";
            this.departToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.departToolStripMenuItem.Text = "Отделы";
            this.departToolStripMenuItem.Click += new System.EventHandler(this.departToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productToolStripMenuItem.Text = "Изделия";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // settlementToolStripMenuItem
            // 
            this.settlementToolStripMenuItem.Name = "settlementToolStripMenuItem";
            this.settlementToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.settlementToolStripMenuItem.Text = "Виды расчетов";
            this.settlementToolStripMenuItem.Click += new System.EventHandler(this.settlementToolStripMenuItem_Click);
            // 
            // ведомостиToolStripMenuItem
            // 
            this.ведомостиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settlementSheetОРасчетахToolStripMenuItem,
            this.productionSheetToolStripMenuItem,
            this.productStandartToolStripMenuItem});
            this.ведомостиToolStripMenuItem.Name = "ведомостиToolStripMenuItem";
            this.ведомостиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ведомостиToolStripMenuItem.Text = "Ведомости";
            // 
            // settlementSheetОРасчетахToolStripMenuItem
            // 
            this.settlementSheetОРасчетахToolStripMenuItem.Name = "settlementSheetОРасчетахToolStripMenuItem";
            this.settlementSheetОРасчетахToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.settlementSheetОРасчетахToolStripMenuItem.Text = "Ведомости расчетов";
            this.settlementSheetОРасчетахToolStripMenuItem.Click += new System.EventHandler(this.settlementSheetToolStripMenuItem_Click);
            // 
            // productionSheetToolStripMenuItem
            // 
            this.productionSheetToolStripMenuItem.Name = "productionSheetToolStripMenuItem";
            this.productionSheetToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.productionSheetToolStripMenuItem.Text = "Ведомости  произведенной продукции";
            this.productionSheetToolStripMenuItem.Click += new System.EventHandler(this.productionSheetToolStripMenuItem_Click);
            // 
            // productStandartToolStripMenuItem
            // 
            this.productStandartToolStripMenuItem.Name = "productStandartToolStripMenuItem";
            this.productStandartToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.productStandartToolStripMenuItem.Text = "Нормы выработки";
            this.productStandartToolStripMenuItem.Click += new System.EventHandler(this.productStandartToolStripMenuItem_Click);
            // 
            // countingToolStripMenuItem
            // 
            this.countingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeePaySheetToolStripMenuItem,
            this.paySheetToolStripMenuItem});
            this.countingToolStripMenuItem.Name = "countingToolStripMenuItem";
            this.countingToolStripMenuItem.ShowShortcutKeys = false;
            this.countingToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.countingToolStripMenuItem.Text = "Расчет зарплаты";
            // 
            // employeePaySheetToolStripMenuItem
            // 
            this.employeePaySheetToolStripMenuItem.Name = "employeePaySheetToolStripMenuItem";
            this.employeePaySheetToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.employeePaySheetToolStripMenuItem.Text = "Расчетный лист";
            this.employeePaySheetToolStripMenuItem.Click += new System.EventHandler(this.employeePaySheetToolStripMenuItem_Click);
            // 
            // paySheetToolStripMenuItem
            // 
            this.paySheetToolStripMenuItem.Name = "paySheetToolStripMenuItem";
            this.paySheetToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.paySheetToolStripMenuItem.Text = "Ведомость по выплате зарплаты";
            this.paySheetToolStripMenuItem.Click += new System.EventHandler(this.paySheetToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 206);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem handbooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settlementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settlementSheetОРасчетахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productStandartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeePaySheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paySheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

