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
    public partial class EmployeesPaySheetForm : Form
    {
        private DepartmentSet departmentSet = new DepartmentSet();
        private EmployeeSet employeeSet = new EmployeeSet();
        private SettlementSheetSet settlementSheetSet = new SettlementSheetSet();
        public EmployeesPaySheetForm()
        {
            InitializeComponent();
            departCbx.DataSource = departmentSet.getListDepartment();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            dataGridPlus.Rows.Clear();
            dataGridMinus.Rows.Clear();

            DataTable dtPlus = settlementSheetSet.getEmployeesSettlesPlus((Employee)employeeCbx.SelectedItem, datePck.Value);
            DataTable dt = settlementSheetSet.getEmployeesSettlesMinus((Employee)employeeCbx.SelectedItem, datePck.Value);
            
            double endSum = 0;
            int i;
            for (i = 0; i < dtPlus.Rows.Count; i++)
            {
                dataGridPlus.Rows.Add();
                dataGridPlus[0, i].Value = dtPlus.Rows[i][0];
                dataGridPlus[1, i].Value = Convert.ToDouble(dtPlus.Rows[i][1]).ToString("F2");

                endSum += Convert.ToDouble(dtPlus.Rows[i][1]);
            }
            double ndfl= Math.Round(endSum * 13 / 100, 2); 

            for (i = 0; i < dt.Rows.Count; i++)
            {
                dataGridMinus.Rows.Add();
                dataGridMinus[0, i].Value = dt.Rows[i][0];
                dataGridMinus[1, i].Value = Convert.ToDouble(dt.Rows[i][1]).ToString("F2");

                endSum -= Convert.ToDouble(dt.Rows[i][1]);
            }
            dataGridMinus.Rows.Add();
            dataGridMinus[0, i].Value = "НДФЛ";
            dataGridMinus[1, i].Value = ndfl.ToString("F2");

            allSumLbl.Text = (endSum- ndfl).ToString("F2") + "";
        }

        private void departCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeCbx.DataSource = employeeSet.getListEmployee((Department)departCbx.SelectedItem);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string path = "";
            Stream myStream;
            if (savePaySheetFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = savePaySheetFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    path = savePaySheetFileDialog.FileName;
                }
            }

            var doc = new Document();
            if (!path.EndsWith(".pdf"))
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
            phrase = new Phrase("Расчетный лист сотрудника \"" + ((Employee)employeeCbx.SelectedItem).second_name + "\"", new
                 iTextSharp.text.Font(baseFont, 15,
                 iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_CENTER;
            parA.Add(Environment.NewLine);
            doc.Add(parA);

            phrase = new Phrase("Месяц: " + datePck.Value.ToString("MMMM yyyy"), new
                 iTextSharp.text.Font(baseFont, 13,
                 iTextSharp.text.Font.NORMAL, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_CENTER;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);


            phrase = new Phrase("Начисления:", new
                 iTextSharp.text.Font(baseFont, 12,
                 iTextSharp.text.Font.BOLD, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_LEFT;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);

            PdfPTable plusTable = new PdfPTable(2);
            plusTable.WidthPercentage = 100;

            var font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));

            PdfPCell cell = new PdfPCell();
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 255,0,0));
            cell.Padding = 8;
            cell.Phrase = new Phrase("Вид расчета", font);
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            plusTable.AddCell(cell);
            cell.Phrase = new Phrase("Сумма", font);
            plusTable.AddCell(cell);

            font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));
            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;

            cell.BackgroundColor = new BaseColor(Color.White);
            for (int i = 0; i < dataGridPlus.Rows.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (dataGridPlus.Rows[i].Cells[j].Value != null && dataGridPlus.Rows[i].Cells[j].Value.ToString() != "0")
                        cell.Phrase = new Phrase(dataGridPlus.Rows[i].Cells[j].Value.ToString(), font);
                    else cell.Phrase = new Phrase("", font);
                    plusTable.AddCell(cell);
                }
            }
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 216, 228, 204));
            
            doc.Add(plusTable);


            phrase = new Phrase("Удержания:", new
                 iTextSharp.text.Font(baseFont, 12,
                 iTextSharp.text.Font.BOLD, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_LEFT;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);



            plusTable = new PdfPTable(2);
            plusTable.WidthPercentage = 100;

            cell = new PdfPCell();
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 216, 228, 204));
            cell.Padding = 8;
            cell.Phrase = new Phrase("Вид расчета", font);
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            plusTable.AddCell(cell);
            cell.Phrase = new Phrase("Сумма", font);
            plusTable.AddCell(cell);

            font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black));
            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;

            cell.BackgroundColor = new BaseColor(Color.White);
            for (int i = 0; i < dataGridMinus.Rows.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (dataGridMinus.Rows[i].Cells[j].Value != null && dataGridMinus.Rows[i].Cells[j].Value.ToString() != "0")
                        cell.Phrase = new Phrase(dataGridMinus.Rows[i].Cells[j].Value.ToString(), font);
                    else cell.Phrase = new Phrase("", font);
                    plusTable.AddCell(cell);
                }
            }
            cell.BackgroundColor = new BaseColor(Color.FromArgb(0, 216, 228, 204));
            
            doc.Add(plusTable);
            

            phrase = new Phrase("Итого: "+allSumLbl.Text, new
                 iTextSharp.text.Font(baseFont, 12,
                 iTextSharp.text.Font.BOLD, new BaseColor(Color.FromArgb(0, 0, 0))));
            parA = new Paragraph(phrase);
            parA.Alignment = Element.ALIGN_LEFT;
            parA.Add(Environment.NewLine);
            parA.Add(Environment.NewLine);
            doc.Add(parA);


            doc.Close();

            MessageBox.Show("Отчет сформирован");
        }
    }
}
