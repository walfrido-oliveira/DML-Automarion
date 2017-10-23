
using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    class Columns : IColumns
    {
        public List<IColumn> ColumnsList { get; set; }
        public string ParamName { get; set; }

        public Columns(List<IColumn> columnsList, string paramName)
        {
            ColumnsList = columnsList;
            ParamName = paramName;
        }

        public string GetColumnString(IColumn column, Types.DML type)
        {
            switch (type)
            {
                case Types.DML.INSERT:
                    if (GetLastIndex() != column.Index) return InsertQuote(column.Name) + ",";
                    else return InsertQuote(column.Name) + ") VALUES (";
                case Types.DML.UPDATE:
                    if (GetLastIndex() != column.Index) return InsertQuote(column.Name) + "=@" + ParamName + "_" + column.Index + ",";
                    else return InsertQuote(column.Name) + "=@" + ParamName + "_" + column.Index;
                case Types.DML.DELETE:
                    break;
                case Types.DML.SELECT:
                    break;
                default:
                    break;
            }
            return string.Empty;
        }

        public string GetValueString(IColumn column, Types.DML type)
        {
            switch (type)
            {
                case Types.DML.INSERT:
                    if (GetLastIndex() != column.Index) return "@" + ParamName + "_" + column.Index + ",";
                    else return "@" + ParamName + "_" + column.Index + ");";
                case Types.DML.UPDATE:
                    break;
                case Types.DML.DELETE:
                    break;
                case Types.DML.SELECT:
                    break;
                default:
                    break;
            }
            return string.Empty;
        }

        public string InsertQuote(string value)
        {
            return "`" + value + "`";
        }

        public int GetLastIndex()
        {
            int index = 0;
            foreach (IColumn column in ColumnsList)
            {
                if (column.Index > index) index = column.Index;
            }
            return index;
        }
    }
}
