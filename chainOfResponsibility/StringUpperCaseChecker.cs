using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            string checkString = "QWERTZUIOPŠĐASDFGHJKLČĆŽYXCVBNM";
            foreach (var letter in stringToCheck)
            {
                if (checkString.Contains(letter))
                    return true;
            }
            return false;
        }
    }
}
