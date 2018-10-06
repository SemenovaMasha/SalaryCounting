using SalaryCounting.EnitiesSets;
using SalaryCounting.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCounting
{
    static class ConnectionClass
    {
        public static SQLiteConnection sql = new SQLiteConnection(@"Data Source=salarycounting.sqlite;Version=3");

        static ConnectionClass()
        {
        }
        public static void setConnectionString(string path)
        {
            sql = new SQLiteConnection(@"Data Source=" + path + ";Version=3");
        }
        public static void executeQuery(string s)
        {
            sql.Open();
            try
            {
                    SQLiteCommand sc = new SQLiteCommand(s, sql);
                    sc.ExecuteNonQuery();
            }
            finally
            {
                sql.Close();
            }
        }
        public static void executeQueryTransaction(string s)
        {
            try
            {
                if (sql != null)
                {
                    if (tr != null)
                    {
                        SQLiteCommand sc = new SQLiteCommand(s, sql);
                        sc.Transaction = tr;
                        sc.ExecuteNonQuery();
                    }
                    else
                    {
                        SQLiteCommand sc = new SQLiteCommand(s, sql);
                        sc.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("sql not open");
                    ExceptionsLogger.logMessage("ошибка при работе с БД в executeQueryTransaction");
                }
            }
            finally
            {
            }
        }
        public static DataTable getResult(string s)
        {
            bool isOpen = sql.State == ConnectionState.Open;
            if (!isOpen)
            sql.Open();
            SQLiteCommand sc = new SQLiteCommand(s, sql);
            SQLiteDataReader sdr = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();

            if (!isOpen)
                sql.Close();

            return dt;
        }

        public static void createEmptyDataBase(string path)
        {
            //SQLiteConnection.CreateFile(path);
            //sql = new SQLiteConnection(@"Data Source=" + path + ";Version=3");

            //executeQuery
            //("create table ");
        }
       static SQLiteTransaction tr;


        public static void startTransaction()
        {
            sql.Open();
            executeQueryTransaction("begin;");


        }
        public static void finishTransaction(bool error)
        {
            try
            {

                if (!error)
                {
                    executeQueryTransaction("commit;");

                }
                else
                {
                    executeQueryTransaction("rollback;");
                }
            }
            finally
            {
                sql.Close();
            }

        }

        public static string generateInsertQuery(BaseEntitySet set, BaseEntity newEntity)
        {
            List<string> fieldsValues = newEntity.getFieldsList();
            string query = "insert into " + set.tableName + " (";

            for (int i = 0; i < set.fieldNames.Count - 1; i++)
            {
                query += set.fieldNames[i] + ",";
            }
            query += set.fieldNames[set.fieldNames.Count - 1] + ") values ('";

            for (int i = 0; i < fieldsValues.Count - 1; i++)
            {
                query += fieldsValues[i] + "','";
            }
            query += fieldsValues[fieldsValues.Count - 1] + "')";

            return query;
        }

        public static string generateUpdateQuery(BaseEntitySet set, BaseEntity editEntity)
        {
            List<string> fieldsValues = editEntity.getFieldsList();
            string query = "update " + set.tableName + " set ";

            for (int i = 0; i < set.fieldNames.Count - 1; i++)
            {
                query += set.fieldNames[i] + " = '" + fieldsValues[i] + "', ";
            }
            query += set.fieldNames[set.fieldNames.Count - 1] + " = '" + fieldsValues[set.fieldNames.Count - 1] + "' where id = " + editEntity.id;

            return query;
        }

        public static string generateDeleteQuery(BaseEntitySet set, BaseEntity editEntity)
        {
            List<string> fieldsValues = editEntity.getFieldsList();
            string query = "delete from " + set.tableName + " where id = " + editEntity.id;
            return query;
        }
    }
}
