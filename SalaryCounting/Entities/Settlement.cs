using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class Settlement : BaseEntity
    {
        public Settlement(int id, string name, bool settle_type_plus, bool settle_sum_fixed, double settle_sum_or_percent):this(name, settle_type_plus,  settle_sum_fixed,  settle_sum_or_percent)
        {
            this.id = id;
        }
        public Settlement(string name, bool settle_type_plus, bool settle_sum_fixed, double settle_sum_or_percent)
        {
            this.name = name;
            this.settle_type_plus = settle_type_plus;
            this.settle_sum_fixed = settle_sum_fixed;
            this.settle_sum_or_percent = settle_sum_or_percent;
        }
        public Settlement(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.name = Convert.ToString(dr[1]);
            this.settle_type_plus = Convert.ToBoolean(dr[2]);
            this.settle_sum_fixed = Convert.ToBoolean(dr[3]);
            this.settle_sum_or_percent = Convert.ToDouble(dr[4]);
        }

        public string name { get; set; }
        public bool settle_type_plus { get; set; }
        public bool settle_sum_fixed { get; set; }
        
        private double Settle_sum_or_percent;
        public double settle_sum_or_percent
        {
            get
            {
                return Math.Round(Settle_sum_or_percent, 2);
            }
            set
            {
                Settle_sum_or_percent = Math.Round(value, 2);
            }
        }

        public override List<string> getFieldsList()
        {
            return new List<string> { name, settle_type_plus.ToString(), settle_sum_fixed.ToString(), (settle_sum_or_percent + "").Replace(",", ".") };
        }
        public Settlement thisObject { get { return this; } }
        public string thisObjectToString { get { return name; } }
    }
}
