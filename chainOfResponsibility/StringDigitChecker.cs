using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            string checkString = "1234567890";
            foreach(var letter in stringToCheck)
            {
                if (checkString.Contains(letter))
                    return true;
            }
            return false;
        }
    }
}
