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
    public partial class ProductsSheetListForm : Form
    {
        ProductsSheetSet set = new ProductsSheetSet();
        List<ProductSheetFilter> list;
        public ProductsSheetListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsSheetForm form = new ProductsSheetForm();
            form.ShowDialog();
            refreshDataGrid();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridSheets.SelectedRows.Count > 0)
            {
                ProductsSheetForm form = new ProductsSheetForm(list[dataGridSheets.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridSheets.SelectedRows.Count > 0)
            {
                set.deleteSheetsFiltered(list[dataGridSheets.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Ведомость удалена");
            }
        }
        private void refreshDataGrid()
        {
            dataGridSheets.DataSource = set.loadSet();
            list = set.getListSheet();

        }
    }
}
