using System.Collections.Generic;
using Walfrido.DML.Automation.Model;
namespace Walfrido.DML.Automation.Controller
{
    interface IColumnController
    {
        List<IColumn> GetColumns(string tableName);
    }
}
