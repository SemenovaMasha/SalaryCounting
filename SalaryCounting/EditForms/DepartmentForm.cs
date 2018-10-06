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
    public partial class DepartmentForm : Form
    {
        private Department editEntity;
        private DepartmentSet departmentSet = new DepartmentSet();
        public DepartmentForm()
        {
            InitializeComponent();

            numberTbx.KeyPress += TextBoxHandles.onlyIntNumbersKeyPress;
        }

        public DepartmentForm(Department editEntity) : this()
        {
            this.editEntity = editEntity;

            numberTbx.Text = editEntity.number + "";
            nameTbx.Text = editEntity.name;
           
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (editEntity == null)
                {
                    Department newEntity = new Department(Convert.ToInt32(numberTbx.Text), nameTbx.Text);

                    departmentSet.addEntity(newEntity);
                    MessageBox.Show("Отдел добавлен");
                }
                else
                {
                    editEntity.number = (Convert.ToInt32(numberTbx.Text));
                    editEntity.name = nameTbx.Text;

                    departmentSet.editEntity(editEntity);
                    MessageBox.Show("Отдел отредактирован");
                }
                    Close();
            }
        }

        private bool checkFields()
        {
            if (nameTbx.Text == "" || numberTbx.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                ExceptionsLogger.logMessage("ошибка при добавлении/редактировании отдела");
                return false;
            }
            

            return true;
        }
    }
}
