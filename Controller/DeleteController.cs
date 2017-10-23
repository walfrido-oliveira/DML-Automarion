namespace Walfrido.DML.Automation.Controller
{
    class DeleteController : IDeleteController
    {
        public Model.IParamsDelete ParamValues { get; set; }
        public DeleteController(Model.IParamsDelete paramValues)
        {
            ParamValues = paramValues;
        }

        public string GetQuery()
        {
            Model.IDML delete = new Model.Delete(ParamValues);
            return delete.GetQuery();
        }
    }
}
