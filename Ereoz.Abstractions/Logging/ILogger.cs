using System;

namespace Ereoz.Abstractions.Logging
{
    public interface ILogger
    {
        void Trace(Exception exception);
        void Trace(string message, params object[] args);
        void Trace(Exception exception, string message, params object[] args);

        void Debug(Exception exception);
        void Debug(string message, params object[] args);
        void Debug(Exception exception, string message, params object[] args);

        void Info(Exception exception);
        void Info(string message, params object[] args);
        void Info(Exception exception, string message, params object[] args);

        void Warn(Exception exception);
        void Warn(string message, params object[] args);
        void Warn(Exception exception, string message, params object[] args);

        void Error(Exception exception);
        void Error(string message, params object[] args);
        void Error(Exception exception, string message, params object[] args);

        void Fatal(Exception exception);
        void Fatal(string message, params object[] args);
        void Fatal(Exception exception, string message, params object[] args);
    }
}
