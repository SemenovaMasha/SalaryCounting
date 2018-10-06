using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    class SettlementSet : BaseEntitySet
    {
        public override string tableName { get { return "settlement"; } }

        public override List<string> fieldNames { get { return new List<string> { "name", "settle_type_plus", "settle_sum_fixed", "settle_sum_or_percent" }; } }

        public override DataTable loadSet()
        {
            return ConnectionClass.getResult("SELECT name as Наименование, case when settle_type_plus=='True' then 'Начисление' else 'Удержание' end as ТипРасчета, case when settle_sum_fixed =='True' then 'Фиксированная сумма' else 'Процент' end as 'Фиксированная сумма или процент',settle_sum_or_percent as Размер FROM settlement;");
        }
        public List<Settlement> getListSettlement ()
        {
            DataTable dt = ConnectionClass.getResult("select id, name, settle_type_plus, settle_sum_fixed, settle_sum_or_percent from settlement");
            List<Settlement> list = new List<Settlement>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Settlement(dt.Rows[i]));
            }
            return list;
        }
    }
}
