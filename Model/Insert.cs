using System.Collections.Generic;
using System.Text;

namespace Walfrido.DML.Automation.Model
{
    class Insert : IDML
    {
        public Insert(IParams @params)
        {
            Columns = @params.Columns ;
            TableName = @params.TableName;
            Values = @params.Values;
        }

        public IColumns Columns { get; set; }
        public string TableName { get; set; }
        public List<object> Values { get; set; }

        public string GetQuery()
        {
            StringBuilder query = new StringBuilder(Types.DML.INSERT.ToString() + " INTO " + Columns.InsertQuote(TableName) + "  (" ) ;
            int count = 0; 
            foreach(IColumn column in Columns.ColumnsList )
            {
                query.Append(Columns.GetColumnString(column,Types.DML.INSERT));
                count++;
            }
            count = 1;
            foreach (IColumn column in Columns.ColumnsList )
            {
                query.Append(Columns.GetValueString(column, Types.DML.INSERT));
                count++;
            }
            return query.ToString();
        }

    }
}
