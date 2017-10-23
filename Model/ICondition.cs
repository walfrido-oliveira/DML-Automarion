namespace Walfrido.DML.Automation.Model
{
    interface ICondition
    {
        IColumn Column { get; set; }
        Operator Operator { get; set; }
        Types.LOGICAL_OPERATOR LogicalOperator { get; set; }
    }
}
