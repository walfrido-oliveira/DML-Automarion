using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    interface IParamsInsert : IParams
    {
        IColumns Columns { get; set; }
        List<Object> Values { get; set; }
    }
}
