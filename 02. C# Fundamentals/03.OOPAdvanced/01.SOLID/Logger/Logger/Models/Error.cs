using System;
using System.Collections.Generic;
using System.Text;
using Logger.Models.Contracts;

namespace Logger.Models
{
    public class Error : IError
    {
        public Error(DateTime dateTime, ReportLevel level, string message)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Message = message;
        }

        public DateTime DateTime { get; }

        public ReportLevel Level { get; }

        public string Message { get; }
    }
}
