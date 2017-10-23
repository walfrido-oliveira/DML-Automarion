using System;
namespace Walfrido.DML.Automation.Model
{
    class ParamsDelete : IParamsDelete
    {
        public String TableName { get; set; }
        public IConditions Conditions { get; set; }
        public string ParamName { get; set; }

        public ParamsDelete()
        {
            Conditions = new Conditions();
        }
    }
}
