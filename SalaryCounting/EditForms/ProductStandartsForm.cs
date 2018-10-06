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

namespace SalaryCounting.EditForms
{
    public partial class ProductStandartsForm : Form
    {
        private ProductStandartFilter filter;

        private ProductStandartSet standartsSet = new ProductStandartSet();
        private DepartmentSet departmentSet = new DepartmentSet();
        private ProductSet productSet = new ProductSet();

        public ProductStandartsForm()
        {
            InitializeComponent();

            departCbx.DataSource = departmentSet.getListDepartment();
            productCbx.DataSource = productSet.getListProduct();


        }
        private List<ProductionStandart> standartList;
        public ProductStandartsForm(ProductStandartFilter filter) : this()
        {
            this.filter = filter;

            for (int i = 0; i < departCbx.Items.Count; i++)
            {
                if (((Department)departCbx.Items[i]).id == filter.department_id)
                {
                    departCbx.SelectedItem = departCbx.Items[i];
                    break;
                }
            }
            for (int i = 0; i < productCbx.Items.Count; i++)
            {
                if (((Product)productCbx.Items[i]).id == filter.product_id)
                {
                    productCbx.SelectedItem = productCbx.Items[i];
                    break;
                }
            }

            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            if (filter != null)
            {
                dataGridOperations.Rows.Clear();
                standartList = standartsSet.getListStandartsFiltered(filter);
                for (int i = 0; i < standartList.Count; i++)
                {
                    dataGridOperations.Rows.Add();
                    dataGridOperations["name", i].Value = standartList[i].operation_name;
                    dataGridOperations["standart", i].Value = standartList[i].standart;
                    dataGridOperations["price", i].Value = standartList[i].operation_price;
                }
            }

        }

        private void dataGridOperations_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dataGridOperations_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                dataGridOperations[e.ColumnIndex, e.RowIndex].ErrorText = "";
                int newInteger;
                
                if (dataGridOperations.Rows[e.RowIndex].IsNewRow) { return; }
                if ((e.FormattedValue.ToString()!="")&&(!int.TryParse(e.FormattedValue.ToString(),out newInteger) || newInteger < 0))
                {
                    dataGridOperations[e.ColumnIndex,e.RowIndex].ErrorText = "норма - целое число";
                }
            }
            else
            if (e.ColumnIndex == 2)
            {
                dataGridOperations[e.ColumnIndex, e.RowIndex].ErrorText = "";
                double newDouble;

                if (dataGridOperations.Rows[e.RowIndex].IsNewRow) { return; }
                if ((e.FormattedValue.ToString() != "") && (!double.TryParse(e.FormattedValue.ToString().Replace(".",","), out newDouble) || newDouble < 0))
                {
                    dataGridOperations[e.ColumnIndex, e.RowIndex].ErrorText = "расценка - действительное число";
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
           

              Close();
        }
        private bool checkFields()
        {
            bool hasErrorText = false;
            foreach (DataGridViewRow row in dataGridOperations.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText.Length > 0)
                    {
                        hasErrorText = true;
                        break;
                    }
                }
                if (hasErrorText)
                    break;
            }
            

            return !hasErrorText;
        }

        private void addStandartBtn_Click(object sender, EventArgs e)
        {
            ProductionStandartForm form = new ProductionStandartForm(filter);
            form.ShowDialog();
            refreshDataGrid();
        }

        private void editStandartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.SelectedRows.Count > 0)
            {
                ProductionStandartForm form = new ProductionStandartForm(standartList[dataGridOperations.SelectedRows[0].Index],filter);
                form.ShowDialog();
                refreshDataGrid();
            }
        }

        private void deleteStandartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.SelectedRows.Count > 0)
            {
                standartsSet.deleteEntity(standartList[dataGridOperations.SelectedRows[0].Index]);
                refreshDataGrid();
            }
        }

        private void departCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departCbx.SelectedItem == null || productCbx.SelectedItem == null )
            {
                return;
            }
            filter = new ProductStandartFilter(((Department)departCbx.SelectedItem).id, ((Product)productCbx.SelectedItem).id);
            refreshDataGrid();
        }
    }
}
