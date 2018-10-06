using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class SettlementSheet :BaseEntity
    {
        public SettlementSheet(int id, int employee_id, int settlement_id, DateTime date, double settlement_sum, int department_id)
            :this( employee_id,  settlement_id,  date,  settlement_sum,  department_id)
        {
            this.id = id;
        }
        public SettlementSheet(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.employee_id = Convert.ToInt32(dr[1]);
            this.settlement_id = Convert.ToInt32(dr[2]);
            this.date = Convert.ToDateTime(dr[3]);
            this.settlement_sum = Convert.ToDouble(dr[4]);
            this.department_id = Convert.ToInt32(dr[5]);
        }

        public SettlementSheet(int employee_id, int settlement_id, DateTime date, double settlement_sum, int department_id)
        {
            this.employee_id = employee_id;
            this.settlement_id = settlement_id;
            this.date = date;
            this.settlement_sum = settlement_sum;
            this.department_id = department_id;
        }

        public int employee_id { get; set; }
        public int settlement_id { get; set; }
        public DateTime date { get; set; }


        private double Settlement_sum;
        public double settlement_sum
        {
            get
            {
                return Math.Round(Settlement_sum, 2);
            }
            set
            {
                Settlement_sum = Math.Round(value, 2);
            }
        }
        public int department_id { get; set; }

        public override List<string> getFieldsList()
        {
            return new List<string> { employee_id + "", settlement_id + "", date.ToString("yyyy-MM-dd"), (settlement_sum + "").Replace(",", "."), department_id + ""};
        }
    }
    public class SettlementSheetFilter
    {
        public DateTime date;
        public int department_id;
        public SettlementSheetFilter(DateTime date, int department_id)
        {
            this.department_id = department_id;
            this.date = date;
        }
        public SettlementSheetFilter(DataRow dr)
        {
            this.department_id = Convert.ToInt32(dr[0]);
            this.date = Convert.ToDateTime(dr[1]);
        }

    }
    public class SettlementSheetMonthSum
    {
        public int employee_id;
        public double sum;
        public SettlementSheetMonthSum(DataRow dr)
        {
            this.employee_id = Convert.ToInt32(dr[0]);
            this.sum = Convert.ToDouble(dr[1]);
        }

        public SettlementSheetMonthSum(int employee_id, double sum)
        {
            this.employee_id = employee_id;
            this.sum = sum;
        }
    }
}

