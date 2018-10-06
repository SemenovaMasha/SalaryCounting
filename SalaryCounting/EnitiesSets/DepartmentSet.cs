using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCounting.Entities;

namespace SalaryCounting.EnitiesSets
{
    class DepartmentSet : BaseEntitySet
    {
        public override string tableName { get { return "department"; } }
        
        public override List<string> fieldNames { get { return new List<string> { "number", "name" }; } }
            
        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("select number as Номер, name as Название from department");
        }

        public List<Department> getListDepartment()
        {
            DataTable dt = ConnectionClass.getResult("select id, number, name from department");
            List<Department> list = new List<Department>();
            for(int i =0;i< dt.Rows.Count; i++)
            {
                list.Add(new Department(dt.Rows[i]));
            }
            return list;
        }
    }
}
