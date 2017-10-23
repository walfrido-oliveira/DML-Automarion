namespace Walfrido.DML.Automation.Controller
{
    interface IUpdateController :IDMLController
    {
        Model.IParamsUpdate ParamValues { get; set; }
    }
}
