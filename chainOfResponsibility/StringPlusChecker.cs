using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class StringPlusChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Contains("+");
        }
    }
}
