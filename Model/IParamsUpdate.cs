
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    interface IParamsUpdate : IParams
    {
        IConditions Conditions { get; set; }
    }
}
