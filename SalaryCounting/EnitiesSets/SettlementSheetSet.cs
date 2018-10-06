using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class SettlementSheetSet : BaseEntitySet
    {
        public override string tableName { get { return "settlement_sheet"; } }

        public override List<string> fieldNames { get { return new List<string> { "employee_id", "settlement_id", "date", "settlement_sum", "department_id" }; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("SELECT distinct department.name as Отдел, date as Дата from settlement_sheet, department " +
                "where settlement_sheet.department_id = department.id  ;");
        }
        public List<SettlementSheetFilter> getListSheet()
        {
            DataTable dt = ConnectionClass.getResult("SELECT distinct department.id as Отдел, date as Дата from settlement_sheet, department " +
                "where settlement_sheet.department_id = department.id  ;");
            List<SettlementSheetFilter> list = new List<SettlementSheetFilter>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheetFilter(dt.Rows[i]));
            }
            return list;
        }
        public List<SettlementSheet> getListSheetsFiltered(SettlementSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT  id,employee_id,settlement_id,date,settlement_sum,department_id " +
                "from settlement_sheet where department_id = " + filter.department_id + " and date = '" + filter.date.ToString("yyyy-MM-dd") + "'");
            List<SettlementSheet> list = new List<SettlementSheet>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheet(dt.Rows[i]));
            }
            return list;
        }
        public List<SettlementSheet> getListSheetsFilteredExceptGeneral(SettlementSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("SELECT  id,employee_id,settlement_id,date,settlement_sum,department_id " +
                "from settlement_sheet where department_id = " + filter.department_id + " and date = '" + filter.date.ToString("yyyy-MM-dd") + 
                "' and settlement_id !=5 and settlement_id !=6 ");
            List<SettlementSheet> list = new List<SettlementSheet>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheet(dt.Rows[i]));
            }
            return list;
        }
        public void deleteSheetsFiltered(SettlementSheetFilter filter)
        {
            ConnectionClass.executeQuery("delete  from settlement_sheet where department_id = " + filter.department_id + " and strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "')");
        }
        public void deleteSheetsFilteredTransaction(SettlementSheetFilter filter)
        {
            ConnectionClass.executeQueryTransaction("delete  from settlement_sheet where department_id = " + filter.department_id + " and strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "')");
        }

        public DataTable getEmployeesSettlesPlus(Employee employee, DateTime date)
        {
            return ConnectionClass.getResult("SELECT settlement.name as 'Вид начисления', CASE WHEN settle_sum_fixed ='True' THEN settlement_sum ELSE settlement_sum*salary/100 END AS Сумма FROM settlement_sheet,settlement,employee where employee_id=" + employee.id + " and settlement.id=settlement_sheet.settlement_id  and strftime('%Y %m', date) = strftime('%Y %m', '" + date.ToString("yyyy-MM-dd") + "') and settle_type_plus = 'True' and employee.id = settlement_sheet.employee_id;");

        }
        public DataTable getEmployeesSettlesMinus(Employee employee, DateTime date)
        {
            return ConnectionClass.getResult("SELECT settlement.name as 'Вид удержания', CASE WHEN settle_sum_fixed ='True' THEN settlement_sum ELSE settlement_sum*salary/100 END AS Сумма FROM settlement_sheet,settlement,employee where employee_id=" + employee.id + " and settlement.id=settlement_sheet.settlement_id  and strftime('%Y %m', date) = strftime('%Y %m', '" + date.ToString("yyyy-MM-dd") + "') and settle_type_plus = 'False' and employee.id = settlement_sheet.employee_id;");

        }
        public List<SettlementSheetMonthSum> getPaySheet(SettlementSheetFilter filter)
        {
            DataTable dt = ConnectionClass.getResult("select employee.id as ФИО, sum(CASE WHEN settle_type_plus ='True' THEN endSum ELSE -endSum END ) AS Сумма from( SELECT employee_id,settle_type_plus, CASE WHEN settle_sum_fixed ='True' THEN settlement_sum ELSE settlement_sum*salary/100 END AS endSum FROM settlement_sheet,settlement,employee where  employee.department_id = " + filter.department_id + " and settlement.id=settlement_sheet.settlement_id  and strftime('%Y %m', date) = strftime('%Y %m', '" + filter.date.ToString("yyyy-MM-dd") + "') and employee.id = settlement_sheet.employee_id) as settles,employee where employee.id=settles.employee_id group by  employee_id");
            List<SettlementSheetMonthSum> list = new List<SettlementSheetMonthSum>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new SettlementSheetMonthSum(dt.Rows[i]));
            }
            return list;
        }

        public void addEntityTransaction(BaseEntity newEntity)
        {
            ConnectionClass.executeQueryTransaction(ConnectionClass.generateInsertQuery(this, newEntity));
        }
    }
}
