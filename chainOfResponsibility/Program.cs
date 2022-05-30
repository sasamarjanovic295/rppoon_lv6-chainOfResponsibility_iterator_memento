using System;

namespace chainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            fileLogger.SetNextLogger(logger);

            fileLogger.Log("Test 1", MessageType.ERROR);
            fileLogger.Log("Test 2", MessageType.WARNING);
            fileLogger.Log("Test 3", MessageType.INFO);

            StringDigitChecker digitChecker = new StringDigitChecker();
            StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            StringLengthChecker lengthChecker = new StringLengthChecker(5);

            digitChecker.SetNext(lowerCaseChecker);
            lowerCaseChecker.SetNext(upperCaseChecker);
            upperCaseChecker.SetNext(lengthChecker);

            Console.WriteLine(digitChecker.Check("adfdsfas"));
            Console.WriteLine(digitChecker.Check("924"));
            Console.WriteLine(digitChecker.Check("3sss"));
            Console.WriteLine(digitChecker.Check("aD3"));
            Console.WriteLine(digitChecker.Check("adfds7Aasfas"));
            Console.WriteLine("---P-----A-------S---------S----");
            PasswordValidator passwordValidator = new PasswordValidator(digitChecker);
            Console.WriteLine(passwordValidator.IsValid("adfds7Aasfas"));
            StringPlusChecker plusChecker = new StringPlusChecker();
            passwordValidator.AddChecker(plusChecker);
            Console.WriteLine(passwordValidator.IsValid("adfds7Aasfas"));
            Console.WriteLine(passwordValidator.IsValid("adfds7+Aasfas"));
        }

    }
}
