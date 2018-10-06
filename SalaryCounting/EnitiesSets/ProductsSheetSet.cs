using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class ProductsSheetSet : BaseEntitySet
    {
        public override string tableName { get { return "products_sheet"; } }

        public override List<string> fieldNames { get { return new List<string> { "employee_id", "product_id", "date","operation_count", "operation_id", "department_id" }; } }
        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("SELECT distinct department.name as Отдел, date as Дата from products_sheet, department " +
                "where products_sheet.department_id = department.id  ;");
        }
        public List<ProductSheetFilter> getListSheet()
        {
            DataTable dt = ConnectionClass.getResult("SELECT distinct department.id as Отдел, date as Дата from products_sheet, department " +
                "where products_sheet.department_id = department.id  ;");
            List<ProductSheetFilter> list = new List<ProductSheetFilter>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new ProductSheetFilter(dt.Rows[i]));
            }
            return list;
        }
        public List<ProductsSheet> getListSheetsFiltered(ProductSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT  id,employee_id,product_id,date,operation_count,operation_id,department_id " +
                "from products_sheet where department_id = " + filter.department_id + " and date = '" + filter.date.ToString("yyyy-MM-dd") + "'");
            List<ProductsSheet> list = new List<ProductsSheet>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new ProductsSheet(dt.Rows[i]));
            }
            return list;
        }
        
        public List<SettlementSheetMonthSum> getListSheetsFilteredMonth(ProductSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT employee_id,sum(operation_count * operation_price) as sum FROM products_sheet,production_standart " +
                "where products_sheet.department_id = " + filter.department_id + " and " +
                "strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "') " +
                "and production_standart.id = products_sheet.operation_id group by employee_id");
            List<SettlementSheetMonthSum> list = new List<SettlementSheetMonthSum>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheetMonthSum(dt.Rows[i]));
            }
            return list;
        }
        public void deleteSheetsFiltered(ProductSheetFilter filter)
        {
            ConnectionClass.executeQuery("delete   from products_sheet where department_id = " + filter.department_id + " and date = '" + filter.date.ToString("yyyy-MM-dd") + "'");
        }
    }
}
