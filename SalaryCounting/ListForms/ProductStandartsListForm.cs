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
    public partial class ProductStandartsListForm : Form
    {
        ProductStandartSet set = new ProductStandartSet();
        List<ProductStandartFilter> list;

        public ProductStandartsListForm()
        {
            InitializeComponent();

            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductStandartsForm form = new ProductStandartsForm();
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridStandarts.SelectedRows.Count > 0)
            {
                ProductStandartsForm form = new ProductStandartsForm(list[dataGridStandarts.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridStandarts.SelectedRows.Count > 0)
            {
                set.deleteStandartsFiltered(list[dataGridStandarts.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Нормы выработки удалены");
            }
        }
        private void refreshDataGrid()
        {
            dataGridStandarts.DataSource = set.loadSet();
            list = set.getListStandart();

        }
    }
}
