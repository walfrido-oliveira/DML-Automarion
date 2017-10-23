using System.Collections.Generic;
using System.Text;

namespace Walfrido.DML.Automation.Model
{
    class Insert : IInsert
    {
        public IColumns Columns { get; set; }
        public string TableName { get; set; }
        public List<object> Values { get; set; }
        public string ParamName { get; set; }

        public Insert(IParamsInsert @params)
        {
            Columns = @params.Columns ;
            ParamName = @params.ParamName;
            TableName = @params.TableName;
            Values = @params.Values;
        }

        public string GetQuery()
        {
            StringBuilder query = new StringBuilder(Types.DML.INSERT.ToString() + " INTO " + Model.Columns.InsertQuote(TableName) + "  (" ) ;
            foreach(IColumn column in Columns.ColumnsList )
            {
                query.Append(Columns.GetColumnString(column,Types.DML.INSERT));
            }
            foreach (IColumn column in Columns.ColumnsList )
            {
                query.Append(Columns.GetValueString(column, Types.DML.INSERT));
            }
            return query.ToString();
        }

    }
}
