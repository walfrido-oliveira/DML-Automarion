namespace Walfrido.DML.Automation.Model
{
    interface IParamsDelete : IParams
    {
        IConditions Conditions { get; set; }
    }
}
