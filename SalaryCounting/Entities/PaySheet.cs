using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class PaySheet:BaseEntity
    {
        public PaySheet(int id, DateTime date, int department_id, int employee_id, double sum)
            : this(date, department_id, employee_id, sum)
        {
            this.id = id;
        }
        public PaySheet(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.date = Convert.ToDateTime(dr[1]);
            this.department_id = Convert.ToInt32(dr[2]);
            this.employee_id = Convert.ToInt32(dr[3]);
            this.sum = Convert.ToDouble(dr[4]);
        }

        public PaySheet(DateTime date, int department_id, int employee_id, double sum)
        {
            this.date = date;
            this.department_id = department_id;
            this.employee_id = employee_id;
            this.sum = sum;
        }
        

        public DateTime date { get; set; }
        public int department_id { get; set; }
        public int employee_id { get; set; }

        private double Sum;
        public double sum
        {
            get
            {
                return Math.Round(Sum, 2);
            }
            set
            {
                Sum = Math.Round(value, 2);
            }
        }

        public override List<string> getFieldsList()
        {
            return new List<string> { date.ToString("yyyy-MM-dd"), department_id + "", employee_id + "",(sum + "").Replace(",", ".")};
        }
    }
    public class PaySheetFilter
    {
        public DateTime date;
        public int department_id;
        public PaySheetFilter(DateTime date, int department_id)
        {
            this.department_id = department_id;
            this.date = date;
        }
        public PaySheetFilter(DataRow dr)
        {
            this.department_id = Convert.ToInt32(dr[0]);
            this.date = Convert.ToDateTime(dr[1]);
        }

    }
}

