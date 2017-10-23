using System;
namespace Walfrido.DML.Automation.Model
{
    interface IDML
    {
        String TableName { get; set; }
        String ParamName { get; set; }
        String GetQuery();
    }
}
