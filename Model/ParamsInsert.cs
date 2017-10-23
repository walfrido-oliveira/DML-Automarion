using System;
using System.Collections.Generic;
namespace Walfrido.DML.Automation.Model
{
    class ParamsInsert : IParamsInsert
    {
        public String TableName { get; set; }
        public IColumns Columns { get; set; }
        public List<Object> Values { get; set; }
        public string ParamName { get; set; }
    }
}
