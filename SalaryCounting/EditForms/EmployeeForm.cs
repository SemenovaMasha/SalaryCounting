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
    public partial class EmployeeForm : Form
    {
        private Employee editEmployee;

        private DepartmentSet departmentSet = new DepartmentSet();
        private EmployeeSet employeeSet = new EmployeeSet();
        public EmployeeForm()
        {
            InitializeComponent();

            tableNumberTbx.KeyPress += TextBoxHandles.onlyIntNumbersKeyPress;
            firstNameTbx.KeyPress += TextBoxHandles.onlyRusSymbolsNoNumKeyPress;
            secondNameTbx.KeyPress += TextBoxHandles.onlyRusSymbolsNoNumKeyPress;
            middleNameTbx.KeyPress += TextBoxHandles.onlyRusSymbolsNoNumKeyPress;
            salaryTbx.KeyPress += TextBoxHandles.onlyPositiveDoubleNumbersKeyPress;

            departmentCbx.DataSource = departmentSet.getListDepartment();
        }
        public EmployeeForm(Employee editEmployee) : this()
        {
            this.editEmployee = editEmployee;

            tableNumberTbx.Text = editEmployee.table_number + "";
            firstNameTbx.Text = editEmployee.first_name ;
            secondNameTbx.Text = editEmployee.second_name;
            middleNameTbx.Text = editEmployee.middle_name;
            salaryTbx.Text = (editEmployee.salary + "").Replace(".",",");

            for(int i = 0; i < departmentCbx.Items.Count; i++)
            {
                if(((Department)departmentCbx.Items[i]).id == editEmployee.department_id)
                {
                    departmentCbx.SelectedItem = departmentCbx.Items[i];
                    break;
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                    if (editEmployee == null)
                    {
                        Employee newEmployee = new Employee(Convert.ToInt32(tableNumberTbx.Text), firstNameTbx.Text, secondNameTbx.Text, middleNameTbx.Text,
                            Convert.ToDouble(salaryTbx.Text), ((Department)departmentCbx.SelectedItem).id);

                        employeeSet.addEntity(newEmployee);
                        MessageBox.Show("Сотрудник добавлен");
                        Close();
                    }
                    else
                    {
                        editEmployee.table_number = (Convert.ToInt32(tableNumberTbx.Text));
                        editEmployee.first_name = firstNameTbx.Text;
                        editEmployee.second_name = secondNameTbx.Text;
                        editEmployee.middle_name = middleNameTbx.Text;
                        editEmployee.salary = Convert.ToDouble(salaryTbx.Text.Replace(".", ","));
                        editEmployee.department_id = ((Department)departmentCbx.SelectedItem).id;

                        employeeSet.editEntity(editEmployee);
                        MessageBox.Show("Сотрудник отредактирован");
                        Close();
                    }
            }
        }
        
        private bool checkFields()
        {
            try
            {
                Convert.ToDouble(salaryTbx.Text.Replace(".", ","));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Оклад введен неверно");
                ExceptionsLogger.logMessage("неверно введен оклад при добавлении/редактировании работника");
                return false;
            }

            if (tableNumberTbx.Text == "" || firstNameTbx.Text == "" || secondNameTbx.Text == "" || middleNameTbx.Text == "" ||departmentCbx.SelectedIndex<0)
            {
                MessageBox.Show("Заполните все поля");
                ExceptionsLogger.logMessage("ошибка при добавлении/редактировании работника");
                return false;
            }


            return true;
        }
    }
}
