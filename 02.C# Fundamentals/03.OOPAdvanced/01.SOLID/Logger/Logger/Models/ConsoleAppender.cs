using System;
using System.Collections.Generic;
using System.Text;
using Logger.Models.Contracts;

namespace Logger.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel level)
        {
            this.Layout = layout;
            this.Level = level;
        }

        public ILayout Layout { get; }

        public ReportLevel Level { get; }


        public void Append(IError error)
        {
            string formattedError = Layout.FormatError(error);
            Console.WriteLine(formattedError);
        }
    }
}
