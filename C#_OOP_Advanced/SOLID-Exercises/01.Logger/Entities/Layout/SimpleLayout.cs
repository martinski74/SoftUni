namespace _01.Logger.Entities.Layout
{
    using Interfaces;

    class SimpleLayout:ILayout

    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}
