namespace Walfrido.DML.Automation.Controller
{
    class InsertController : IInsertController
    {
        public Model.IParams ParamValues { get; set; }
        public InsertController(Model.IParams paramValues)
        {
            this.ParamValues = paramValues;
        }

        public string GetQuery()
        {
            Model.IDML insert = new Model.Insert(ParamValues);
            return insert.GetQuery();
        }
    }
}
