using System;
using System.Collections.Generic;
namespace Walfrido.DML.Automation.Model
{
    interface IDML
    {
        String TableName { get; set; }
        IColumns Columns  { get; set; }
        List<Object> Values { get; set; }
        String GetQuery();
    }
}
