using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    abstract class StringChecker
    {
        private StringChecker next;

        internal StringChecker Next { get => next; }

        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.Next != null && result == true)
            {
                return this.Next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }


}
