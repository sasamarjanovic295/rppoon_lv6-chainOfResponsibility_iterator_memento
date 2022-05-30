using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            string checkString = "qwertzuiopšđasdfghjklčćžyxcvbnm";
            foreach (var letter in stringToCheck)
            {
                if (checkString.Contains(letter))
                    return true;
            }
            return false;
        }
    }
}
