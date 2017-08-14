using System.Text;

namespace _01.Logger.Entities.Layout
{
    using System;
    using Interfaces;

    class XmlLayout:ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            StringBuilder msg = new StringBuilder();

            return msg.AppendLine($"<log>")
                .AppendLine($"  <date>{timeStamp}</date>")
                .AppendLine($"  <level>{reportLevel}</level>")
                .AppendLine($"  <message>{message}</message>")
                .Append($"</log>")
                .ToString();
        }
    }
}
