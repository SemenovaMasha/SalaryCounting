using SalaryCounting.EditForms;
using SalaryCounting.EnitiesSets;
using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCounting.ListForms
{
    public partial class EmployeeListForm : Form
    {
        EmployeeSet set = new EmployeeSet();
        List<Employee> list;
        public EmployeeListForm()
        {
            InitializeComponent();

            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.SelectedRows.Count > 0)
            {
                EmployeeForm form = new EmployeeForm(list[dataGridEmployees.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridEmployees.SelectedRows.Count > 0)
            {
                set.deleteEntity(list[dataGridEmployees.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Сотрудник удален");
            }
        }

        private void refreshDataGrid()
        {
            dataGridEmployees.DataSource = set.loadSet();
            list = set.getListEmployee();

        }
    }
}
