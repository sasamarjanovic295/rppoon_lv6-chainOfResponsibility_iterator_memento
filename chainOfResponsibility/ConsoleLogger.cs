using System;
using System.Collections.Generic;
using System.Text;

namespace chainOfResponsibility
{
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(MessageType messageType) : base(messageType) { }
        protected override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(type + ": " + DateTime.Now);
            Console.WriteLine(new string('=', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('=', message.Length) + "\n");
        }
    }
}
