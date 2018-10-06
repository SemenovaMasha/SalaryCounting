using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCounting.Entities;
using System.Data;

namespace SalaryCounting.EnitiesSets
{
    class EmployeeSet : BaseEntitySet
    {
        public override string tableName { get { return "employee"; } }

        public override List<string> fieldNames { get { return new List<string> {"table_number", "first_name", "second_name", "middle_name", "salary", "department_id" }; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("select table_number as 'Табельный номер', first_name as Имя,second_name as Фамилия,middle_name as Отчество,salary as Оклад, name as Отдел from department, employee where employee.department_id = department.id");
        }

        public List<Employee> getListEmployee()
        {
            DataTable dt = ConnectionClass.getResult("select id, table_number,first_name,second_name,middle_name,salary,department_id from employee");
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Employee(dt.Rows[i]));
            }
            return list;
        }
        public List<Employee> getListEmployee(Department depart)
        {
            DataTable dt = ConnectionClass.getResult("select id, table_number,first_name,second_name,middle_name,salary,department_id from employee where department_id=" +depart.id);
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Employee(dt.Rows[i]));
            }
            return list;
        }
        public List<SettlementSheetMonthSum> getListSheetsFilteredMonth(ProductSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT employee_id,sum(operation_count * operation_price) as sum FROM products_sheet,production_standart " +
                "where products_sheet.department_id = " + filter.department_id + " and " +
                "strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "') " +
                "and production_standart.id = products_sheet.operation_id group by employee_id");
            List<SettlementSheetMonthSum> list = new List<SettlementSheetMonthSum>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheetMonthSum(dt.Rows[i]));
            }
            return list;
        }
    }
}
