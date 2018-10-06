using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.Entities
{
    public class Product : BaseEntity
    {
        public Product(int id, string articul, string name):this(articul,name)
        {
            this.id = id;
        }
        public Product(string articul, string name) 
        {
            this.articul = articul;
            this.name = name;
        }
        public Product(DataRow dr)
        {
            this.id = Convert.ToInt32(dr[0]);
            this.articul = Convert.ToString(dr[1]);
            this.name = Convert.ToString(dr[2]);
        }

        public string articul { get; set; }
        public string name { get; set; }

        public override List<string> getFieldsList()
        {
            return new List<string> { articul,name };
        }
        public override string ToString()
        {
            return articul+ " "+ name;
        }
        public Product thisObject { get { return this; } }
        public string thisObjectToString { get { return articul + " " + name; } }
    }
}
