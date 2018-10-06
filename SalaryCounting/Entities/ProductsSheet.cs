using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class ProductsSheet :BaseEntity
    {
        public ProductsSheet(int employee_id, int product_id, DateTime date, int operation_count, int operation_id, int department_id)
        {
            this.employee_id = employee_id;
            this.product_id = product_id;
            this.date = date;
            this.operation_count = operation_count;
            this.operation_id = operation_id;
            this.department_id = department_id;
        }
        public ProductsSheet(int id, int employee_id, int product_id, DateTime date, int operation_count, int operation_id, int department_id)
            :this( employee_id,  product_id,  date,  operation_count,  operation_id,  department_id)
        {
            this.id = id;
        }
        public ProductsSheet(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.employee_id = Convert.ToInt32(dr[1]);
            this.product_id = Convert.ToInt32(dr[2]);
            this.date = Convert.ToDateTime(dr[3]);
            this.operation_count = Convert.ToInt32(dr[4]);
            this.operation_id = Convert.ToInt32(dr[5]);
            this.department_id = Convert.ToInt32(dr[6]);
        }

        public int employee_id { get; set; }
        public int product_id { get; set; }
        public DateTime date { get; set; }
        public int operation_count { get; set; }
        public int operation_id { get; set; }
        public int department_id { get; set; }

        public override List<string> getFieldsList()
        {
            return new List<string> { employee_id+"", product_id + "", date.ToString("yyyy-MM-dd"), operation_count + "", operation_id + "", department_id + "" };
        }
    }
    public class ProductSheetFilter
    {
        public DateTime date;
        public int department_id;
        public ProductSheetFilter(DateTime date,int department_id)
        {
            this.department_id = department_id;
            this.date = date;
        }
        public ProductSheetFilter(DataRow dr)
        {
            this.department_id = Convert.ToInt32(dr[0]);
            this.date = Convert.ToDateTime(dr[1]);
        }

    }
}
