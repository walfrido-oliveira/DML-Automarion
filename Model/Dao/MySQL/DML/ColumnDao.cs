using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Walfrido.DML.Automation.Model.Dao.MySQL.DML
{
    class ColumnDao : AbstractDao , IColumnsDao, IDisposable
    {
        public ColumnDao(MySqlConnection conn) : base(conn)
        {            
        }

        public IColumn BuildColumn(MySqlDataReader myData)
        {
            IColumn columns = new Column();
            columns.Name = myData.GetString("COLUMN_NAME");
            if(!myData.IsDBNull(10)) columns.Size = myData.GetInt32("NUMERIC_PRECISION") + 1;
            columns.TypeValue = (Types.Values)Enum.Parse(typeof(Types.Values),  myData.GetString("DATA_TYPE").ToUpper());
            columns.Index = myData.GetInt32("ORDINAL_POSITION");
            return columns;
        }

        public void Dispose()
        {
            base.conn.Clone();
        }

        public List<IColumn> GetColumns(string tableName)
        {
            string SQL = "SELECT * FROM information_schema.COLUMNS WHERE TABLE_NAME = @param_1;";
            List<IColumn> columns = new List<IColumn>();
            using (MySqlCommand command = new MySqlCommand(SQL))
            {
                command.Parameters.AddWithValue("param_1", tableName);
                command.Connection = conn;
                using(MySqlDataReader myData = command.ExecuteReader())
                {
                    if (myData != null)
                    {
                        while(myData.Read())
                        {
                            columns.Add(BuildColumn(myData));
                        }
                    }
                }
            }
            return columns;
        }
    }
}
