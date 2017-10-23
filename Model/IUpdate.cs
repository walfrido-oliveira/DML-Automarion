namespace Walfrido.DML.Automation.Model
{
    interface IUpdate : IDML
    {
        IConditions Conditions { get; set; }
    }
}
