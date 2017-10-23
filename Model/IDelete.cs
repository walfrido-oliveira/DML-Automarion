namespace Walfrido.DML.Automation.Model
{
    interface IDelete : IDML
    {
        IConditions Conditions { get; set; }
    }
}
