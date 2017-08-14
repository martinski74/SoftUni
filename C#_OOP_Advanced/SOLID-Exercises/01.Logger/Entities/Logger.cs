using System;
using _01.Logger.Enums;

namespace _01.Logger.Entities
{
    using _01.Logger.Interfaces;
    public class Logger:ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        private void Log(string timeStamp,string reportLevel, string message)
        {
            foreach (IAppender appender in this.appenders)
            {
                ReportLevel currentLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);

                if (appender.ReportLevel <= currentLevel)
                {
                    appender.Append(timeStamp, reportLevel, message);
                }   
            }
        }

        public void Error(string timeStamp, string message)
        {
            this.Log(timeStamp,"Error",message);
        }

        public void Info(string timeStamp, string message)
        {
            this.Log(timeStamp,"Info",message);
        }

        public void Fatal(string timeStamp, string message)
        {
            this.Log(timeStamp, "Fatal", message);
        }

        public void Critical(string timeStamp, string message)
        {
            this.Log(timeStamp, "Critical", message);
        }

        public void Warn(string timeStamp, string message)
        {
            this.Log(timeStamp, "Warning", message);
        }
    }
}
