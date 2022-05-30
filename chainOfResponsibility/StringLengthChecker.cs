using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class StringLengthChecker : StringChecker
    {
        public int MinLength { get; }
        public StringLengthChecker(int minLength) : base()
        {
            MinLength = minLength;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length >= MinLength)
                return true;
            return false;
        }
    }
}
