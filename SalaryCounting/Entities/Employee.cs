using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class Employee:BaseEntity
    {
        public Employee(int id, int table_number, string first_name, string second_name, string middle_name, double salary, int department_id) : this(table_number,  first_name,  second_name,  middle_name,  salary,  department_id)
        {
            this.id = id;
        }
        public Employee(int table_number, string first_name, string second_name, string middle_name, double salary, int department_id)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.middle_name = middle_name;
            this.salary = salary;
            this.department_id = department_id;
            this.table_number = table_number;
        }
        public Employee(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.table_number = Convert.ToInt32(dr[1]);
            this.first_name = Convert.ToString(dr[2]); 
            this.second_name = Convert.ToString(dr[3]); 
            this.middle_name = Convert.ToString(dr[4]); 
            this.salary = Convert.ToDouble(dr[5]);
            this.department_id = Convert.ToInt32(dr[6]); 
        }

        public string first_name { get; set; }
        public string second_name { get; set; }
        public string middle_name { get; set; }
        private double Salary;
        public double salary
        {
            get
            {
                return Math.Round(Salary, 2);
            }
            set
            {
                Salary = Math.Round(value, 2);
            }
        }
        public int department_id { get; set; }
        public int table_number { get; set; }

        public override List<string> getFieldsList()
        {
            return new List<string> {table_number + "",first_name, second_name, middle_name, (salary +"").Replace(",","."), department_id + "" };
        }
        public override string ToString()
        {
            return second_name + " " + first_name + " " + middle_name;
        }
        public Employee thisObject { get { return this; } }
        public string thisObjectToString { get { return second_name + " " + first_name + " " + middle_name; } }
    }
}
