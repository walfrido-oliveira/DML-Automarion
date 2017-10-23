using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    interface IInsert : IDML
    {
        IColumns Columns { get; set; }
        List<Object> Values { get; set; }
    }
}
