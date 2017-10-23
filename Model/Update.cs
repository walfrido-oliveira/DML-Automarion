using System.Collections.Generic;
using System.Text;

namespace Walfrido.DML.Automation.Model
{
    class Update : IUpdate
    {
        public IColumns Columns { get; set; }
        public string TableName { get; set; }
        public List<object> Values { get; set; }
        public IConditions Conditions { get; set; }
        public string ParamName { get; set; }

        public Update(IParamsUpdate @params)
        {
            Columns = @params.Columns;
            ParamName = @params.ParamName;
            TableName = @params.TableName;
            Values = @params.Values;
            Conditions = @params.Conditions;
        }

        public string GetQuery()
        {
            StringBuilder query = new StringBuilder(Types.DML.UPDATE.ToString()  + " " + Model.Columns.InsertQuote(TableName) + " SET ");
            foreach (IColumn column in Columns.ColumnsList)
            {
                query.Append(Columns.GetColumnString(column, Types.DML.UPDATE));
            }
            query.Append(Conditions.GetStringCondition(ParamName, Columns.GetLastIndex()));
            return query.ToString();
        }
    }
}
