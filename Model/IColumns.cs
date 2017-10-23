using System;
using System.Collections.Generic;
namespace Walfrido.DML.Automation.Model
{
    interface IColumns
    {
        String GetColumnString(IColumn column, Types.DML type);
        String GetValueString(IColumn column, Types.DML type);
        String InsertQuote(string value);
        String ParamName { get; set; }
        List<IColumn> ColumnsList { get; set; }
        int GetLastIndex();
    }
}
