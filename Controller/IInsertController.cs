namespace Walfrido.DML.Automation.Controller
{
    interface IInsertController : IDMLController
    {
        Model.IParams ParamValues { get; set; }
    }
}
