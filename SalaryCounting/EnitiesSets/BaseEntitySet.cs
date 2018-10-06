using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCounting.EnitiesSets
{
    abstract class BaseEntitySet
    {
        public abstract string tableName { get; }
        public abstract List<string> fieldNames { get; }

        public List<BaseEntity> entityList { get; set; }

        public abstract DataTable loadSet();
        public void addEntity(BaseEntity newEntity)
        {
            ConnectionClass.executeQuery(ConnectionClass.generateInsertQuery(this, newEntity));
        }
        public void editEntity(BaseEntity newEntity)
        {
            ConnectionClass.executeQuery(ConnectionClass.generateUpdateQuery(this, newEntity));
        }
        public void deleteEntity(BaseEntity newEntity)
        {
            ConnectionClass.executeQuery(ConnectionClass.generateDeleteQuery(this, newEntity));
        }

    }
}
