using _01.Logger.Enums;

namespace _01.Logger.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string timeStamp, string reportLevel, string message);
    }
}