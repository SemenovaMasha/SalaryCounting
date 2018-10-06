using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class PaySheetSet : BaseEntitySet
    {
        public override string tableName { get { return "pay_sheet"; } }

        public override List<string> fieldNames { get { return new List<string> { "date", "department_id", "employee_id", "sum" }; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("SELECT distinct department.name as Отдел, date as Дата from pay_sheet, department " +
                "where pay_sheet.department_id = department.id  ;");
        }
        public List<PaySheetFilter> getListSheet()
        {
            DataTable dt = ConnectionClass.getResult("SELECT distinct department.id as Отдел, date as Дата from pay_sheet, department " +
                "where pay_sheet.department_id = department.id  ;");
            List<PaySheetFilter> list = new List<PaySheetFilter>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new PaySheetFilter(dt.Rows[i]));
            }
            return list;
        }
        public List<PaySheet> getListSheetsFiltered(PaySheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT  id,date,department_id,employee_id,sum " +
                "from pay_sheet where department_id = " + filter.department_id + " and date = '" + filter.date.ToString("yyyy-MM-dd") + "'");
            List<PaySheet> list = new List<PaySheet>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new PaySheet(dt.Rows[i]));
            }
            return list;
        }
        
        public void deleteSheetsFiltered(PaySheetFilter filter)
        {
            ConnectionClass.executeQuery("delete  from pay_sheet where department_id = " + filter.department_id + " and "
                + "strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "') "  );
        }
    }
    }
