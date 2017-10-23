using System.Collections.Generic;
using System.Text;

namespace Walfrido.DML.Automation.Model
{
    class Conditions : IConditions
    {
        public List<ICondition> ConditionList { get; set; }

        public Conditions()
        {
            this.ConditionList = new List<ICondition>();
        }

        public string InsertQuote(string value)
        {
            return "`" + value + "`";
        }

        public string GetStringCondition(string paramName, int lastIndex)
        {
            StringBuilder query = new StringBuilder();
            int count = 0;
            foreach (ICondition item in ConditionList)
            {
                if (count == 0)
                {
                    switch (item.Operator.Operador)
                    {
                        case Types.OPERATOR.BETWEEN:
                            query.Append(" WHERE " + InsertQuote(item.Column.Name) + " " + item.Operator.OperatorValue + " " +
                                         "@" + paramName + "_" + (lastIndex + 1) +  " AND " + "@" + paramName + "_" + (lastIndex + 2) + " ");
                            break;
                        case Types.OPERATOR.IN:
                            break;
                        default:
                            query.Append(" WHERE " + InsertQuote(item.Column.Name) + " " + item.Operator.OperatorValue + " " + "@" + paramName + "_" + (lastIndex + 1) + " ");
                            break;
                    }
                }
                else
                {
                    switch (item.Operator.Operador)
                    {
                        case Types.OPERATOR.BETWEEN:
                            query.Append(item.LogicalOperator.ToString() + " " + InsertQuote(item.Column.Name) + " " + item.Operator.OperatorValue + " " + "@" +
                                         paramName + "_" + (lastIndex + 1 + count) + " AND " + "@" + paramName + "_" + (lastIndex + 2 + count) + " ");
                            break;
                        case Types.OPERATOR.IN:
                            break;
                        default:
                            query.Append(item.LogicalOperator.ToString() + " " + InsertQuote(item.Column.Name) + " " + item.Operator.OperatorValue + " " +
                                         "@" + paramName + "_" + (lastIndex + 1 + count) + " ");
                            break;
                    }
                }
                count++;
            }
            return query.ToString();
        }
    }
}
