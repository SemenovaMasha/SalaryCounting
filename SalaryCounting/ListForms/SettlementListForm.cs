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
    public partial class SettlementListForm : Form
    {
        SettlementSet set = new SettlementSet();
        List<Settlement> list;
        public SettlementListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettlementForm form = new SettlementForm();
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridSettlements.SelectedRows.Count > 0)
            {
                SettlementForm form = new SettlementForm(list[dataGridSettlements.SelectedRows[0].Index]);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridSettlements.SelectedRows.Count > 0)
            {
                set.deleteEntity(list[dataGridSettlements.SelectedRows[0].Index]);
                refreshDataGrid();
                MessageBox.Show("Вид расчета удален");
            }
        }
        private void refreshDataGrid()
        {
            dataGridSettlements.DataSource = set.loadSet();
            list = set.getListSettlement();

        }
    }
}

