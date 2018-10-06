using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class Department: BaseEntity
    {
        public Department(int id, int number, string name) : this(number,name) 
        {
            this.id = id;
        }
        public Department(int number,string name )
        {
            this.name = name;
            this.number = number;
        }
        public Department(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.number = Convert.ToInt32(dr[1]);
            this.name = Convert.ToString(dr[2]);
        }

        public int number { get; set; }
        public string name { get; set; }

        public override List<string> getFieldsList()
        {
            return new List<string> { number+"", name };
        }

        public override string ToString()
        {
            return name;
        }
    }
}
