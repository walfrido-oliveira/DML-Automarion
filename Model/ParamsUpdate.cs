using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    class ParamsUpdate : IParamsUpdate
    {
        public String TableName { get; set; }
        public IColumns Columns { get; set; }
        public List<Object> Values { get; set; }
        public IConditions Conditions { get; set; }

        public ParamsUpdate()
        {
            Values = new List<object>();
            Conditions = new Conditions();
        }
    }
}
