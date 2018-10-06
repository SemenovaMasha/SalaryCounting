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
    public partial class ProductForm : Form
    {
        private Product editEntity;
        private ProductSet productSet = new ProductSet();
        public ProductForm()
        {
            InitializeComponent();
            
        }

        public ProductForm(Product editEntity) : this()
        {
            this.editEntity = editEntity;

            numberTbx.Text = editEntity.articul;
            nameTbx.Text = editEntity.name;

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (editEntity == null)
                {
                    Product newEntity = new Product(numberTbx.Text, nameTbx.Text);

                    productSet.addEntity(newEntity);
                    MessageBox.Show("Изделие добавлено");
                }
                else
                {
                    editEntity.articul = numberTbx.Text;
                    editEntity.name = nameTbx.Text;

                    productSet.editEntity(editEntity);
                    MessageBox.Show("Изделие отредактировано");
                }
                Close();
            }
        }

        private bool checkFields()
        {

            if (numberTbx.Text == "" || nameTbx.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                ExceptionsLogger.logMessage("ошибка при добавлении/редактировании изделия");
                return false;
            }


            return true;
        }
    }
}
