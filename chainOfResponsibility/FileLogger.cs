using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace chainOfResponsibility
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(type);
                writer.WriteLine(message);
            }
        }
    }
}
