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
    public partial class ProductsSheetForm : Form
    {
        private ProductSheetFilter filter;

        private ProductsSheetSet productSheetSet = new ProductsSheetSet();
        private DepartmentSet departmentSet = new DepartmentSet();
        private EmployeeSet employeeSet = new EmployeeSet();
        private ProductSet productSet = new ProductSet();
        private ProductStandartSet productStandartSet = new ProductStandartSet();

        public ProductsSheetForm()
        {
            InitializeComponent();

            departCbx.DataSource = departmentSet.getListDepartment();
            departCbx.SelectedIndex = 0;

            ((DataGridViewComboBoxColumn)(operations_table.Columns["product"])).DataSource = productSet.getListProduct();
            ((DataGridViewComboBoxColumn)(operations_table.Columns["product"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(operations_table.Columns["product"])).DisplayMember = "thisObjectToString";

        }
        public ProductsSheetForm(ProductSheetFilter filter) : this()
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
            datePck.Value = filter.date;

            List<ProductsSheet> list = productSheetSet.getListSheetsFiltered(filter);
            for (int i = 0; i < list.Count; i++)
            {
                operations_table.Rows.Add();

                for (int j = 0; j < ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["employee"])).Items[j]).id == list[i].employee_id)
                    {
                        ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }
                }

                for (int j = 0; j < ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["product"])).Items.Count; j++)
                {
                    if (((Product)((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["product"])).Items[j]).id == list[i].product_id)
                    {
                        ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["product"])).Value = ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["product"])).Items[j];
                        break;
                    }
                }

                ProductStandartFilter filterRow = new ProductStandartFilter(((Department)departCbx.SelectedItem).id, ((Product)(operations_table.Rows[i].Cells["product"].Value)).id);
                
                ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).DataSource = productStandartSet.getListStandartsFiltered(filterRow);
                ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).ValueMember = "thisObject";
                ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).DisplayMember = "thisObjectToString";


                for (int j = 0; j < ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).Items.Count; j++)
                {
                    if (((ProductionStandart)((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).Items[j]).id == list[i].operation_id)
                    {
                        ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).Value = ((DataGridViewComboBoxCell)(operations_table.Rows[i].Cells["operation"])).Items[j];
                        break;
                    }
                }
                operations_table["count", i].Value = list[i].operation_count;
            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (filter == null)
                {
                    for (int i = 0; i < operations_table.Rows.Count - 1; i++)
                    {
                        ProductsSheet newEntity = new ProductsSheet(((Employee)operations_table["employee", i].Value).id, ((Product)operations_table["product", i].Value).id, datePck.Value,
                            Convert.ToInt32(operations_table["count", i].Value), ((ProductionStandart)operations_table["operation", i].Value).id, ((Department)departCbx.SelectedItem).id);

                        productSheetSet.addEntity(newEntity);
                    }
                    MessageBox.Show("Ведомость добавлена");
                }
                else
                {
                    productSheetSet.deleteSheetsFiltered(filter);

                    for (int i = 0; i < operations_table.Rows.Count - 1; i++)
                    {
                        ProductsSheet newEntity = new ProductsSheet(((Employee)operations_table["employee", i].Value).id, ((Product)operations_table["product", i].Value).id, datePck.Value,
                            Convert.ToInt32(operations_table["count", i].Value), ((ProductionStandart)operations_table["operation", i].Value).id, ((Department)departCbx.SelectedItem).id);

                        productSheetSet.addEntity(newEntity);
                    }
                    MessageBox.Show("Ведомость отредактирована");
                }
                Close();
            }
            else
            {
            }

        }
        private bool checkFields()
        {
            bool hasErrorText = false;
            foreach (DataGridViewRow row in operations_table.Rows)
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
                {
                    MessageBox.Show("Ошибки в таблице");
                    ExceptionsLogger.logMessage("ошибки в таблице при добавлении/редактировании ведомости по нормам выработки");
                    break;
                }
            }
            for (int i = 0; i < operations_table.Rows.Count - 1; i++)
            {
                if (operations_table["employee", i].Value == null || operations_table["product", i].Value == null
                    || operations_table["operation", i].Value == null || operations_table["count", i].Value == null || operations_table["count", i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните все поля");
                    ExceptionsLogger.logMessage("ошибка при добавлении/редактировании ведомости по нормам выработки");
                    return false;
                }

            }


                return !hasErrorText;
        }

        private void departCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DataGridViewComboBoxColumn)(operations_table.Columns["employee"])).DataSource = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
            ((DataGridViewComboBoxColumn)(operations_table.Columns["employee"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(operations_table.Columns["employee"])).DisplayMember = "thisObjectToString";
        }
        

        private void operations_table_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void operations_table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (operations_table.CurrentCell.ColumnIndex == 1 )
            {
                var currentcell = operations_table.CurrentCellAddress;

                ProductStandartFilter filter = new ProductStandartFilter(((Department)departCbx.SelectedItem).id, ((Product)(operations_table.Rows[currentcell.Y].Cells["product"].Value)).id);


                ((DataGridViewComboBoxCell)(operations_table.Rows[currentcell.Y].Cells["operation"])).DataSource = productStandartSet.getListStandartsFiltered(filter);

                ((DataGridViewComboBoxCell)(operations_table.Rows[currentcell.Y].Cells["operation"])).ValueMember = "thisObject";
                ((DataGridViewComboBoxCell)(operations_table.Rows[currentcell.Y].Cells["operation"])).DisplayMember = "thisObjectToString";
            }

        }

        private void operations_table_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                operations_table[e.ColumnIndex, e.RowIndex].ErrorText = "";
                int newInteger;

                if (operations_table.Rows[e.RowIndex].IsNewRow) { return; }
                if ((e.FormattedValue.ToString() != "") && (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0))
                {
                    operations_table[e.ColumnIndex, e.RowIndex].ErrorText = "количество - целое число";
                }
            }
        }
    }
}
