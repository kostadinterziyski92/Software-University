using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Contracts
{
    public interface ILogger
    {
        void Log(IError error);
    }
}
