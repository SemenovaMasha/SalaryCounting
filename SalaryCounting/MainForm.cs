using SalaryCounting.EditForms;
using SalaryCounting.EnitiesSets;
using SalaryCounting.Entities;
using SalaryCounting.ListForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCounting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void departToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new DepartmentListForm());
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new EmployeeListForm());
        }

        private void showNewForm(Form form)
        {
            form.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new ProductListForm());
        }

        private void settlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new SettlementListForm());
        }

        private void productStandartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new ProductStandartsListForm());
        }
        
        
        private void paySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new PaySheetsListForm());

        }

        private void productionSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new ProductsSheetListForm());


        }

        private void employeePaySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new EmployeesPaySheetForm());

        }

        private void settlementSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewForm(new SettlementSheetListForm());

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new HelpingForm()).Show();

        }

        private void handbooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
