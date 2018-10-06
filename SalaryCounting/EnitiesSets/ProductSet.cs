using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class ProductSet : BaseEntitySet
    {
        public override string tableName { get { return "product"; } }

        public override List<string> fieldNames { get { return new List<string> { "articul", "name"}; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("select articul as Артикул, name as Название from product");
        }
        public List<Product> getListProduct()
        {
            DataTable dt = ConnectionClass.getResult("select id, articul, name from product");
            List<Product> list = new List<Product>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Product(dt.Rows[i]));
            }
            return list;
        }
    }
}
