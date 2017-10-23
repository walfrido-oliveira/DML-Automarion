
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model.Dao
{
    interface IColumnsDao
    {
        List<IColumn> GetColumns(string tableName);
        IColumn BuildColumn(MySqlDataReader myData);
    }
}
