using System.Text;

namespace Walfrido.DML.Automation.Model
{
    class Delete : IDelete
    {
        public string TableName { get; set; }
        public IConditions Conditions { get; set; }
        public string ParamName { get; set; }

        public Delete(IParamsDelete @params)
        {
            TableName = @params.TableName;
            Conditions = @params.Conditions;
            ParamName = @params.ParamName;
        }

        public string GetQuery()
        {
            StringBuilder query = new StringBuilder(Types.DML.DELETE.ToString() + " FROM " + Columns.InsertQuote(TableName) + " ");
            query.Append(Conditions.GetStringCondition(ParamName, 0));
            return query.ToString();
        }
    }
}
