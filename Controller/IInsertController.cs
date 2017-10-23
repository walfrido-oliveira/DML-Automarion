namespace Walfrido.DML.Automation.Controller
{
    interface IInsertController : IDMLController
    {
        Model.IParamsInsert ParamValues { get; set; }
    }
}
