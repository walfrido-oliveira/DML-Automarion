using System;
using System.Collections.Generic;
using Walfrido.DML.Automation.Model;

namespace Walfrido.DML.Automation.Controller
{
    class ColumnsController : IColumnController
    {
        public Model.Dao.IURL url;
        public ColumnsController(Model.Dao.IURL  url)
        {
            this.url = url;
        }

        public List<IColumn> GetColumns(string tableName)
        {
            Model.Dao.IColumnsDao columnDao = new Model.Dao.MySQL.DML.ColumnDao(new Model.Dao.MySQL.ConnectionFactory(url).GetConnection());
            return columnDao.GetColumns(tableName);
        }
    }
}
