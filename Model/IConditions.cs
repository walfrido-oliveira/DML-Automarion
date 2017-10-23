using System;
using System.Collections.Generic;
namespace Walfrido.DML.Automation.Model
{
    interface IConditions
    {
        String InsertQuote(string value);
        List<ICondition> ConditionList { get; set; }
        String GetStringCondition(string paramName, int lastIndex);
    }
}
