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
    public partial class SettlementForm : Form
    {
        private Settlement editEntity;
        private SettlementSet settlementSet = new SettlementSet();
        public SettlementForm()
        {
            InitializeComponent();

            sizeTbx.KeyPress += TextBoxHandles.onlyPositiveDoubleNumbersKeyPress;

            typeCbx.Items.Add("Начисление");
            typeCbx.Items.Add("Удержание");
            typeCbx.SelectedIndex = 0;
        }


        public SettlementForm(Settlement editEntity) : this()
        {
            this.editEntity = editEntity;

            nameTbx.Text = editEntity.name;
            typeCbx.SelectedIndex = editEntity.settle_type_plus ? 0 : 1;
            if (editEntity.settle_sum_fixed)
                fixedChbx.Checked = true;
            sizeTbx.Text = (editEntity.settle_sum_or_percent + "").Replace(".", ","); ;

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (editEntity == null)
                {
                    Settlement newEntity = new Settlement(nameTbx.Text, typeCbx.SelectedIndex == 0 ? true:false,fixedChbx.Checked,Convert.ToDouble(sizeTbx.Text));

                    settlementSet.addEntity(newEntity);
                    MessageBox.Show("Вид расчета добавлен");
                }
                else
                {
                    editEntity.name = nameTbx.Text;
                    editEntity.settle_type_plus = typeCbx.SelectedIndex == 0 ? true : false;
                    editEntity.settle_sum_fixed = fixedChbx.Checked;
                    editEntity.settle_sum_or_percent = Convert.ToDouble(sizeTbx.Text.Replace(".", ","));

                    settlementSet.editEntity(editEntity);
                    MessageBox.Show("Вид расчета отредактирован");
                }
                Close();
            }
        }

        private bool checkFields()
        {
            try
            {
                Convert.ToDouble(sizeTbx.Text.Replace(".", ","));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Размер введен неверно");
                ExceptionsLogger.logMessage("неверно введен размер при добавлении/редактировании расчета");
                return false;
            }

            if (nameTbx.Text == ""  || typeCbx.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все поля");
                ExceptionsLogger.logMessage("ошибка при добавлении/редактировании расчета");
                return false;
            }



            return true;
        }
    }
}
