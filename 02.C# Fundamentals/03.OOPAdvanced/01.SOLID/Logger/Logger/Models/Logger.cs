using System;
using System.Collections.Generic;
using System.Text;
using Logger.Models.Contracts;

namespace Logger.Models
{
    public class Logger : ILogger
    {
        private IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public void Log(IError error)
        {
            foreach (IAppender appender in appenders)
            {
                if (appender.Level <= error.Level )
                {
                    appender.Append(error);
                }
            }
        }
    }
}
