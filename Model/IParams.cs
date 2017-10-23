using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    interface IParams
    {
        String TableName { get; set; }
        IColumns Columns { get; set; }
        List<Object> Values { get; set; }
    }
}
