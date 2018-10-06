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
    public partial class SettlementSheetListForm : Form
    {
        SettlementSheetSet set = new SettlementSheetSet();
        List<SettlementSheetFilter> list;
        public SettlementSheetListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettlementSheetForm form = new SettlementSheetForm();
            form.ShowDialog();
            refreshDataGrid();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridSheets.SelectedRows.Count > 0)
            {
                SettlementSheetForm form = new SettlementSheetForm(list[dataGridSheets.SelectedRows[0].Index]);
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
