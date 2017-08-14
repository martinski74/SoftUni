using System.Dynamic;
using _01.Logger.Enums;

namespace _01.Logger.Entities.Appenders
{
    using Interfaces;

    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public LogFile File {get;set;}

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formatMessage = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formatMessage);
        }
    }
}
