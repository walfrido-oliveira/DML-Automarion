using System;
namespace Walfrido.DML.Automation.Model
{
    interface IColumn
    {
        String Name { get; set; }
        Types.Values TypeValue { get; set; }
        int? Size { get; set; }
        int Index { get; set; }
    }
}
