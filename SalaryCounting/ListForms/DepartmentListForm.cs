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
    public partial class DepartmentListForm : Form
    {
        DepartmentSet set = new DepartmentSet();
        List<Department> list;
        public DepartmentListForm()
        {
            InitializeComponent();

            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDepartments.SelectedRows.Count > 0)
            {
                DepartmentForm form = new DepartmentForm(list[dataGridDepartments.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDepartments.SelectedRows.Count > 0)
            {
                set.deleteEntity(list[dataGridDepartments.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Отдел удален");
            }
        }

        private void refreshDataGrid()
        {
            dataGridDepartments.DataSource = set.loadSet();
            list = set.getListDepartment();

        }
    }
}
