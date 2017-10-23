namespace Walfrido.DML.Automation.Controller
{
    interface IDeleteController : IDMLController
    {
        Model.IParamsDelete ParamValues { get; set; }
    }
}
