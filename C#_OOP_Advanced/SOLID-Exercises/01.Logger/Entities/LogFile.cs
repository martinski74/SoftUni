using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.Logger.Entities
{
    public class LogFile
    {
        private const string DefaultFileName = "log.txt";
        private StringBuilder strinBuilder;

        public LogFile()
        {
            this.strinBuilder = new StringBuilder();
        }

        public int Size { get; private set; }

        private int GetLetteresOnlySum(string message)
        {
            return message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }
        public void Write(string message)
        {
            this.strinBuilder.AppendLine(message);
            File.AppendAllText(DefaultFileName,message + Environment.NewLine);
            this.Size = this.GetLetteresOnlySum(message);
        }
    }
}
