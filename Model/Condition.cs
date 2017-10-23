namespace Walfrido.DML.Automation.Model
{
    class Condition : ICondition
    {
        public IColumn Column { get; set; }
        public Operator Operator { get; set; }
        public Types.LOGICAL_OPERATOR LogicalOperator { get; set; }
    }
}
