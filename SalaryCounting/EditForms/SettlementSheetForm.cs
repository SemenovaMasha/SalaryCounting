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
    public partial class SettlementSheetForm : Form
    {
        private SettlementSheetFilter filter;
        private ProductSheetFilter productSheetFilter;

        private SettlementSheetSet settleSheetSet = new SettlementSheetSet();
        private ProductsSheetSet productSheetSet = new ProductsSheetSet();
        private DepartmentSet departmentSet = new DepartmentSet();
        private EmployeeSet employeeSet = new EmployeeSet();
        private SettlementSet settleSet = new SettlementSet();
        public SettlementSheetForm()
        {
            InitializeComponent();

            departCbx.DataSource = departmentSet.getListDepartment();
            departCbx.SelectedIndex = 0;

            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DataSource = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DisplayMember = "thisObjectToString";

            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["settle_type"])).DataSource = settleSet.getListSettlement();
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["settle_type"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["settle_type"])).DisplayMember = "thisObjectToString";

        }
        public SettlementSheetForm(SettlementSheetFilter filter) : this()
        {
            this.filter = filter;

            recountBtn.Visible = true;

            for (int i = 0; i < departCbx.Items.Count; i++)
            {
                if (((Department)departCbx.Items[i]).id == filter.department_id)
                {
                    departCbx.SelectedItem = departCbx.Items[i];
                    break;
                }
            }
            datePck.Value = filter.date;

            List<SettlementSheet> list = settleSheetSet.getListSheetsFiltered(filter);
            for (int i = 0; i < list.Count; i++)
            {
                dataGridSheet.Rows.Add();

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j]).id == list[i].employee_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }
                }

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items.Count; j++)
                {
                    if (((Settlement)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j]).id == list[i].settlement_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j];
                        break;
                    }
                }
                dataGridSheet["value", i].Value = list[i].settlement_sum;
            }

        }


        private void filTableBtn_Click(object sender, EventArgs e)
        {
            dataGridSheet.Rows.Clear();

            List<Employee> employees = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
            int i = 0;
            for (; i < employees.Count; i++)
            {
                dataGridSheet.Rows.Add();

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j]).id == employees[i].id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }

                }
                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items.Count; j++)
                {
                    if (((Settlement)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j]).id == 5)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j];
                        break;
                    }
                }

                dataGridSheet["value", i].Value = employees[i].salary;
            }
            productSheetFilter = new ProductSheetFilter(datePck.Value, ((Department)(departCbx.SelectedItem)).id);

            List<SettlementSheetMonthSum> list = productSheetSet.getListSheetsFilteredMonth(productSheetFilter);
            for (int k = 0; k < list.Count; i++, k++)
            {
                dataGridSheet.Rows.Add();

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j]).id == list[k].employee_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }
                }

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items.Count; j++)
                {
                    if (((Settlement)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j]).id == 6)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j];
                        break;
                    }
                }



                dataGridSheet["value", i].Value = list[k].sum;
            }



        }
        private bool checkFields()
        {
            bool hasErrorText = false;
            foreach (DataGridViewRow row in dataGridSheet.Rows)
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
                    ExceptionsLogger.logMessage("ошибки в таблице при добавлении/редактировании ведрмости начислений и удержаний");
                    break;
                }
            }

            for (int i = 0; i < dataGridSheet.Rows.Count - 1; i++)
            {
                if (dataGridSheet["employee", i].Value == null || dataGridSheet["settle_type", i].Value == null
                    || dataGridSheet["value", i].Value == null || dataGridSheet["value", i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните все поля");
                    ExceptionsLogger.logMessage("ошибка при добавлении/редактировании ведрмости начислений и удержаний");
                    return false;
                }

            }


            return !hasErrorText;
        }

        private bool noMinus()
        {
            List<Employee> employees = employeeSet.getListEmployee((Department)departCbx.SelectedItem);

            for (int k = 0; k < employees.Count; k++)
            {
                DataTable dtPlus = settleSheetSet.getEmployeesSettlesPlus(employees[k], datePck.Value);
                DataTable dt = settleSheetSet.getEmployeesSettlesMinus(employees[k], datePck.Value);

                double endSum = 0;
                int i = 0;

                for (i = 0; i < dtPlus.Rows.Count; i++)
                {
                    endSum += Convert.ToDouble(dtPlus.Rows[i][1]);
                }

                double ndfl = Math.Round(endSum * 13 / 100, 2);
                
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    endSum -= Convert.ToDouble(dt.Rows[i][1]);
                }
                
                endSum = (endSum - ndfl);

                if (endSum < 0)
                {
                    MessageBox.Show("Сумма выплаты зарплаты (" + endSum + ") меньше нуля для работника : " + employees[k]);
                    return false;
                }
            }
            return true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                ConnectionClass.startTransaction();
                if (filter == null)
                {
                    settleSheetSet.deleteSheetsFilteredTransaction(new SettlementSheetFilter(datePck.Value, ((Department)departCbx.SelectedItem).id));
                    for (int i = 0; i < dataGridSheet.Rows.Count - 1; i++)
                    {
                        SettlementSheet newEntity = new SettlementSheet(((Employee)dataGridSheet["employee", i].Value).id, ((Settlement)dataGridSheet["settle_type", i].Value).id, datePck.Value, Convert.ToDouble(dataGridSheet["value", i].Value), ((Department)departCbx.SelectedItem).id);

                        settleSheetSet.addEntityTransaction(newEntity);
                    }
                }
                else
                {
                    settleSheetSet.deleteSheetsFilteredTransaction(filter);

                    for (int i = 0; i < dataGridSheet.Rows.Count - 1; i++)
                    {
                        SettlementSheet newEntity = new SettlementSheet(((Employee)dataGridSheet["employee", i].Value).id, ((Settlement)dataGridSheet["settle_type", i].Value).id, datePck.Value, Convert.ToDouble(dataGridSheet["value", i].Value), ((Department)departCbx.SelectedItem).id);

                        settleSheetSet.addEntityTransaction(newEntity);
                    }
                }

                if (!noMinus())
                {
                    ConnectionClass.finishTransaction(true);
                }
                else
                {
                    ConnectionClass.finishTransaction(false);
                    if (filter == null)
                    {
                        MessageBox.Show("Ведомость добавлена");
                    }
                    else
                    {
                        MessageBox.Show("Ведомость отредактирована");
                    }
                    Close();
                }

            }
            else
            {
            }
        }

        private void departCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DataSource = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DisplayMember = "thisObjectToString";

            dataGridSheet.Rows.Clear();
        }

        private void dataGridSheet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridSheet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSheet.CurrentCell.ColumnIndex == 1)
            {
                var currentcell = dataGridSheet.CurrentCellAddress;

                dataGridSheet["value", currentcell.Y].Value = ((Settlement)(dataGridSheet["settle_type", currentcell.Y].Value)).settle_sum_or_percent;

            }
        }

        private void recountBtn_Click(object sender, EventArgs e)
        {
            filTableBtn_Click(null, null);

            List<SettlementSheet> list = settleSheetSet.getListSheetsFilteredExceptGeneral(filter);
            int i = dataGridSheet.Rows.Count - 1;
            for (int k = 0; k < list.Count; k++, i++)
            {
                dataGridSheet.Rows.Add();

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j]).id == list[k].employee_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }
                }

                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items.Count; j++)
                {
                    if (((Settlement)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j]).id == list[k].settlement_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["settle_type"])).Items[j];
                        break;
                    }
                }
                dataGridSheet["value", i].Value = list[k].settlement_sum;
            }

        }

        private void dataGridSheet_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dataGridSheet[e.ColumnIndex, e.RowIndex].ErrorText = "";
                double newDouble;

                if (dataGridSheet.Rows[e.RowIndex].IsNewRow) { return; }
                if ((e.FormattedValue.ToString() != "") && (!double.TryParse(e.FormattedValue.ToString().Replace(".", ","), out newDouble) || newDouble < 0))
                {
                    dataGridSheet[e.ColumnIndex, e.RowIndex].ErrorText = "сумма - действительное число";
                }
                else
                if ((e.FormattedValue.ToString().Length > 18))
                {
                    dataGridSheet[e.ColumnIndex, e.RowIndex].ErrorText = "слишком большое число";
                }
            }
        }
    }
}
