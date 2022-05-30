using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class PasswordValidator
    {
        public StringChecker stringChecker;
        public PasswordValidator(StringChecker checker)
        {
            stringChecker = checker;
        }
        public bool IsValid(String password)
        {
            return stringChecker.Check(password);
        }
        public void AddChecker(StringChecker checker)
        {
            StringChecker tmpChecker = stringChecker;
            while (tmpChecker.Next != null)
                tmpChecker = tmpChecker.Next;
            tmpChecker.SetNext(checker);
        }
    }
}
