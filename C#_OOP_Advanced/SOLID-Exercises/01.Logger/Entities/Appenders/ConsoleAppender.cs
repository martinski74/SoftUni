using System;
using _01.Logger.Enums;

namespace _01.Logger.Entities.Appenders
{
    using Interfaces;

    class ConsoleAppender : IAppender
    {
    
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

      public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formatedMessage = this.Layout.FormatMessage(timeStamp,reportLevel, message);
            Console.WriteLine(formatedMessage);
        }
    }
}
