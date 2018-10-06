using iTextSharp.text;
using iTextSharp.text.pdf;
using SalaryCounting.EnitiesSets;
using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCounting.EditForms
{
    public partial class PaySheetForm : Form
    {
        private SettlementSheetSet settlementSheetSet = new SettlementSheetSet();
        private DepartmentSet departmentSet = new DepartmentSet();
        private EmployeeSet employeeSet = new EmployeeSet();
        private PaySheetSet paySheetSet = new PaySheetSet();
        
        private PaySheetFilter filter;
        public PaySheetForm()
        {
            InitializeComponent();
            departCbx.DataSource = departmentSet.getListDepartment();
            departCbx.SelectedIndex = 0;
        }
        public PaySheetForm(PaySheetFilter filter) : this()
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

            List<PaySheet> list = paySheetSet.getListSheetsFiltered(filter);
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
                
                dataGridSheet["sum", i].Value = list[i].sum;
            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (filter == null)
                {
                    paySheetSet.deleteSheetsFiltered(new PaySheetFilter(datePck.Value,
                            ((Department)departCbx.SelectedItem).id));

                    for (int i = 0; i < dataGridSheet.Rows.Count ; i++)
                    {
                        PaySheet newEntity = new PaySheet(datePck.Value, 
                            ((Department)departCbx.SelectedItem).id,((Employee)dataGridSheet["employee", i].Value).id, 
                             Convert.ToDouble(dataGridSheet["sum", i].Value));

                        paySheetSet.addEntity(newEntity);
                    }
                    MessageBox.Show("Ведомость добавлена");
                }
                else
                {
                    paySheetSet.deleteSheetsFiltered(filter);

                    for (int i = 0; i < dataGridSheet.Rows.Count ; i++)
                    {
                        PaySheet newEntity = new PaySheet(datePck.Value,
                            ((Department)departCbx.SelectedItem).id, ((Employee)dataGridSheet["employee", i].Value).id,
                             Convert.ToDouble(dataGridSheet["sum", i].Value));

                        paySheetSet.addEntity(newEntity);
                    }
                    MessageBox.Show("Ведомость отредактирована");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Ошибки в таблице");
                ExceptionsLogger.logMessage("ошибка в таблице при добавлении/редактировании ведомости выплаты зарплаты");
            }
        }

        private void filTableBtn_Click(object sender, EventArgs e)
        {
            dataGridSheet.Rows.Clear();

            List<SettlementSheetMonthSum> sums = settlementSheetSet.getPaySheet(new SettlementSheetFilter(datePck.Value, ((Department)(departCbx.SelectedItem)).id));
            int i = 0;
            for (; i < sums.Count; i++)
            {
                dataGridSheet.Rows.Add();
                
                for (int j = 0; j < ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items.Count; j++)
                {
                    if (((Employee)((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j]).id == sums[i].employee_id)
                    {
                        ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Value = ((DataGridViewComboBoxCell)(dataGridSheet.Rows[i].Cells["employee"])).Items[j];
                        break;
                    }

                }

                dataGridSheet["sum", i].Value = sums[i].sum;
            }
            
        }

        private void departCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DataSource = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).ValueMember = "thisObject";
            ((DataGridViewComboBoxColumn)(dataGridSheet.Columns["employee"])).DisplayMember = "thisObjectToString";
        }

        private void dataGridSheet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

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
                    break;
            }


            return !hasErrorText;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string path = "";
            if (savePaySheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = savePaySheetFileDialog.FileName;
            }

            var doc = new Document();

            
                path.Replace(".pdf", "");
            path += " (Ведомость по выплате зарплаты отдела '" + ((Department)departCbx.SelectedItem).name + "' от " + datePck.Value.ToString("yyyy-MM-dd")+")";

                path += ".pdf";
            PdfWriter.GetInstance(doc, new FileStream(path,
            FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(@"Tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            Phrase phrase = new Phrase("От " + DateTime.Today.ToShortDateString(), new
                iTextSharp.text.Font(baseFont, 13,
                iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0, 0, 0))));
            Paragraph parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_RIGHT;
            parA.Add(Environment.NewLine);
            doc.Add(parA);
            phrase = new Phrase("Расчетный лист отдела \"" + ((Department)departCbx.SelectedItem).name + "\"", new
                 iTextSharp.text.Font(baseFont, 15,
                 iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_CENTER;
            parA.Add(Environment.NewLine);
            doc.Add(parA);

            phrase = new Phrase("Дата: " + datePck.Value.ToString("MMMM yyyy"), new
                 iTextSharp.text.Font(baseFont, 13,
                 iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_CENTER;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);

            
            PdfPTable plusTable = new PdfPTable(2);
            plusTable.WidthPercentage = 100;

            var font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));

            PdfPCell cell = new PdfPCell();
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 216, 228, 204));
            cell.Padding = 8;
            cell.Phrase = new Phrase("Сотрудник", font);
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            plusTable.AddCell(cell);
            cell.Phrase = new Phrase("Сумма", font);
            plusTable.AddCell(cell);

            font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));
            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;

            cell.BackgroundColor = new BaseColor(Color.White);

            double allSum = 0;
            for (int i = 0; i < dataGridSheet.Rows.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (dataGridSheet.Rows[i].Cells[j].Value != null )
                        cell.Phrase = new Phrase(dataGridSheet.Rows[i].Cells[j].Value.ToString(), font);
                    else cell.Phrase = new Phrase("", font);
                    plusTable.AddCell(cell);
                }
                allSum += Convert.ToDouble(dataGridSheet.Rows[i].Cells[1].Value);
            }
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 216, 228, 204));

            doc.Add(plusTable);

            

            phrase = new Phrase("Итого по отделу: " + allSum, new
                 iTextSharp.text.Font(baseFont, 12,
                 iTextSharp.text.Font.BOLD, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_LEFT;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);


            doc.Close();
        }
    }
}
