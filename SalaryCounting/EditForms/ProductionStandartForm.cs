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
    public partial class ProductionStandartForm : Form
    {
        private ProductionStandart editEntity;
        private ProductStandartSet standartsSet = new ProductStandartSet();
        private ProductStandartFilter filter;
        public ProductionStandartForm(ProductStandartFilter filter)
        {
            this.filter = filter;
            InitializeComponent();


            standartTbx.KeyPress += TextBoxHandles.onlyIntNumbersKeyPress;
            priceTbx.KeyPress += TextBoxHandles.onlyPositiveDoubleNumbersKeyPress;
        }
        public ProductionStandartForm(ProductionStandart editEntity, ProductStandartFilter filter) : this(filter)
        {
            this.editEntity = editEntity;
            
            nameTbx.Text = editEntity.operation_name;
            standartTbx.Text = editEntity.standart+"";
            priceTbx.Text = editEntity.operation_price+"";

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (editEntity == null)
                {
                    ProductionStandart newEntity = new ProductionStandart(filter.department_id,filter.product_id, nameTbx.Text, Convert.ToInt32(standartTbx.Text), Convert.ToDouble(priceTbx.Text.Replace(".",",")));

                    standartsSet.addEntity(newEntity);
                    MessageBox.Show("Норма выработки добавлена");
                }
                else
                {
                    editEntity.operation_name = nameTbx.Text;
                    editEntity.standart = (Convert.ToInt32(standartTbx.Text));
                    editEntity.operation_price = (Convert.ToDouble(priceTbx.Text.Replace(".", ",")));

                    standartsSet.editEntity(editEntity);
                    MessageBox.Show("Норма выработки отредактирована");
                }
                Close();
            }
        }

        private bool checkFields()
        {

            try
            {
                Convert.ToDouble(priceTbx.Text.Replace(".", ","));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Расценка введена неверно");
                ExceptionsLogger.logMessage("неверно введена расценка при добавлении/редактировании нормы выработки");
                return false;
            }

            if (nameTbx.Text == "" || standartTbx.Text == "" || priceTbx.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                ExceptionsLogger.logMessage("ошибка при добавлении/редактировании нормы выработки");
                return false;
            }



            return true;
        }
    }
}
