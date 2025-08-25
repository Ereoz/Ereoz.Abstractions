using System;

namespace Ereoz.Abstractions.Logging
{
    public class NullLogger : ILogger
    {
        public void Debug(Exception exception) { }

        public void Debug(string message, params object[] args) { }

        public void Debug(Exception exception, string message, params object[] args) { }

        public void Error(Exception exception) { }

        public void Error(string message, params object[] args) { }

        public void Error(Exception exception, string message, params object[] args) { }

        public void Fatal(Exception exception) { }

        public void Fatal(string message, params object[] args) { }

        public void Fatal(Exception exception, string message, params object[] args) { }

        public void Info(Exception exception) { }

        public void Info(string message, params object[] args) { }

        public void Info(Exception exception, string message, params object[] args) { }

        public void Trace(Exception exception) { }

        public void Trace(string message, params object[] args) { }

        public void Trace(Exception exception, string message, params object[] args) { }

        public void Warn(Exception exception) { }

        public void Warn(string message, params object[] args) { }

        public void Warn(Exception exception, string message, params object[] args) { }
    }
}
