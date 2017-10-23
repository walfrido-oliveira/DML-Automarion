using System;
using System.Collections.Generic;
namespace Walfrido.DML.Automation.Model
{
    interface IConditions
    {
        List<ICondition> ConditionList { get; set; }
        String GetStringCondition(string paramName, int lastIndex);
    }
}
