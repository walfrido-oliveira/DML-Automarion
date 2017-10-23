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

        public Update(IParamsUpdate @params)
        {
            Columns = @params.Columns;
            TableName = @params.TableName;
            Values = @params.Values;
            Conditions = @params.Conditions;
        }

        public string GetQuery()
        {
            StringBuilder query = new StringBuilder(Types.DML.UPDATE.ToString()  + " " + Columns.InsertQuote(TableName) + " SET ");
            int count = 0;
            foreach (IColumn column in Columns.ColumnsList)
            {
                query.Append(Columns.GetColumnString(column, Types.DML.UPDATE));
                count++;
            }
            query.Append(Conditions.GetStringCondition(Columns.ParamName, Columns.GetLastIndex()));
            return query.ToString();
        }
    }
}
