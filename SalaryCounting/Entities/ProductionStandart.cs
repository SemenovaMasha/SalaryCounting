using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class ProductionStandart :BaseEntity
    {
        public ProductionStandart(int id, int department_id, int product_id, string operation_name, int standart, double operation_price) :this( department_id,  product_id,  operation_name,  standart,  operation_price)
        {
            this.id = id;
        }
        public ProductionStandart(int department_id , int product_id , string operation_name , int standart , double operation_price) 
        {
            this.department_id = department_id;
            this.product_id = product_id;
            this.operation_name = operation_name;
            this.standart = standart;
            this.operation_price = operation_price;
        }
        public ProductionStandart(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.department_id = Convert.ToInt32(dr[1]);
            this.product_id = Convert.ToInt32(dr[2]);
            this.operation_name = Convert.ToString(dr[3]);
            this.standart = Convert.ToInt32(dr[4]);
            this.operation_price = Convert.ToDouble(dr[5]);
        }
        
        public int department_id { get; set; }
        public int product_id { get; set; }
        public string operation_name { get; set; }
        public int standart { get; set; }

        private double Operation_price;
        public double operation_price
        {
            get
            {
                return Math.Round(Operation_price, 2);
            }
            set
            {
                Operation_price = Math.Round(value, 2);
            }
        }

        public override List<string> getFieldsList()
        {
            return new List<string> { department_id + "", product_id + "", operation_name , standart + "", (operation_price + "").Replace(",",".") };
        }

        public ProductionStandart thisObject { get { return this; } }
        public string thisObjectToString { get { return operation_name ; } }
    }
    public class ProductStandartFilter
    {
        public int department_id;
        public int product_id;
        public ProductStandartFilter(int department_id,int product_id)
        {
            this.department_id = department_id;
            this.product_id = product_id;
        }
        public ProductStandartFilter(DataRow dr)
        {
            this.department_id = Convert.ToInt32(dr[0]);
            this.product_id = Convert.ToInt32(dr[1]);
        }


    }
}
