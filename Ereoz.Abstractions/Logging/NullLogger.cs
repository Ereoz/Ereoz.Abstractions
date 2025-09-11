using System;

namespace Ereoz.Abstractions.Logging
{
    /// <summary>
    /// An empty logger.
    /// </summary>
    public sealed class NullLogger : ILogger
    {
        /// <inheritdoc/>
        public void Debug(Exception exception) { }

        /// <inheritdoc/>
        public void Debug(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Debug(Exception exception, string message, params object[] args) { }

        /// <inheritdoc/>
        public void Error(Exception exception) { }

        /// <inheritdoc/>
        public void Error(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Error(Exception exception, string message, params object[] args) { }

        /// <inheritdoc/>
        public void Fatal(Exception exception) { }

        /// <inheritdoc/>
        public void Fatal(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Fatal(Exception exception, string message, params object[] args) { }

        /// <inheritdoc/>
        public void Info(Exception exception) { }

        /// <inheritdoc/>
        public void Info(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Info(Exception exception, string message, params object[] args) { }

        /// <inheritdoc/>
        public void Trace(Exception exception) { }

        /// <inheritdoc/>
        public void Trace(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Trace(Exception exception, string message, params object[] args) { }

        /// <inheritdoc/>
        public void Warn(Exception exception) { }

        /// <inheritdoc/>
        public void Warn(string message, params object[] args) { }

        /// <inheritdoc/>
        public void Warn(Exception exception, string message, params object[] args) { }
    }
}
