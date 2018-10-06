using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class ProductStandartSet : BaseEntitySet
    {
        public override string tableName { get { return "production_standart"; } }

        public override List<string> fieldNames { get { return new List<string> { "department_id", "product_id", "operation_name", "standart", "operation_price" }; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("SELECT distinct department.name as Отдел, product.name as Изделие from production_standart, department,product " +
                "where production_standart.department_id = department.id and production_standart.product_id = product.id  ;");
        }
        public List<ProductStandartFilter> getListStandart()
        {
            DataTable dt = ConnectionClass.getResult("SELECT distinct department.id as Отдел, product.id as Изделие from production_standart, department,product " +
                "where production_standart.department_id = department.id and production_standart.product_id = product.id  ;");
            List<ProductStandartFilter> list = new List<ProductStandartFilter>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new ProductStandartFilter(dt.Rows[i]));
            }
            return list;
        }
        public List<ProductionStandart> getListStandartsFiltered(ProductStandartFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT  id,department_id,product_id,operation_name,standart,operation_price from production_standart where department_id = "+filter.department_id+" and product_id = "+filter.product_id);
            List<ProductionStandart> list = new List<ProductionStandart>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new ProductionStandart(dt.Rows[i]));
            }
            return list;
        }
        public void deleteStandartsFiltered(ProductStandartFilter filter)
        {
            ConnectionClass.executeQuery("delete   from production_standart where department_id = " + filter.department_id + " and product_id = " + filter.product_id);
        }
    }
}
