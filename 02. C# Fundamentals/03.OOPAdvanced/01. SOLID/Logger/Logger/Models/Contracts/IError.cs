using System;

namespace Logger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }

        ReportLevel Level { get; }

        string Message { get; }
    }
}