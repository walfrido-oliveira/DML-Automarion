using System;

namespace Walfrido.DML.Automation.Model
{
    interface IParams
    {
        String TableName { get; set; }
        String ParamName { get; set; }
    }
}
