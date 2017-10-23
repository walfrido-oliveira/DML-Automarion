namespace Walfrido.DML.Automation.Controller
{
    class UpdateController : IUpdateController
    {
        public Model.IParamsUpdate ParamValues { get; set; }
        public UpdateController(Model.IParamsUpdate paramValues)
        {
            this.ParamValues = paramValues;
        }

        public string GetQuery()
        {
            Model.IDML update = new Model.Update(ParamValues);
            return update.GetQuery();
        }
    }
}

