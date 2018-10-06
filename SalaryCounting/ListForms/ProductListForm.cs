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
    public partial class ProductListForm : Form
    {
        ProductSet set = new ProductSet();
        List<Product> list;
        public ProductListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                ProductForm form = new ProductForm(list[dataGridProducts.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                set.deleteEntity(list[dataGridProducts.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Изделие удалено");
            }
        }
        private void refreshDataGrid()
        {
            dataGridProducts.DataSource = set.loadSet();
            list = set.getListProduct();

        }
    }
}
