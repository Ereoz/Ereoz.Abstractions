using System;

namespace Ereoz.Abstractions.Logging
{
    /// <summary>
    /// Defines the contract for logging operations.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a trace-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Trace(Exception exception);

        /// <summary>
        /// Logs a trace-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Trace(string message, params object[] args);

        /// <summary>
        /// Logs a trace-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Trace(Exception exception, string message, params object[] args);

        /// <summary>
        /// Logs a debug-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Debug(Exception exception);

        /// <summary>
        /// Logs a debug-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Logs a debug-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Debug(Exception exception, string message, params object[] args);

        /// <summary>
        /// Logs a info-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Info(Exception exception);

        /// <summary>
        /// Logs a info-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Info(string message, params object[] args);

        /// <summary>
        /// Logs a info-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Info(Exception exception, string message, params object[] args);

        /// <summary>
        /// Logs a warn-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Warn(Exception exception);

        /// <summary>
        /// Logs a warn-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Warn(string message, params object[] args);

        /// <summary>
        /// Logs a warn-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Warn(Exception exception, string message, params object[] args);

        /// <summary>
        /// Logs a error-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Error(Exception exception);

        /// <summary>
        /// Logs a error-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Logs a error-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Error(Exception exception, string message, params object[] args);

        /// <summary>
        /// Logs a fatal-level message with an exception.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        void Fatal(Exception exception);

        /// <summary>
        /// Logs a fatal-level message with optional arguments for formatting.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// Logs a fatal-level message with an exception and optional arguments for formatting.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">The message to log.</param>
        /// <param name="args">An array of objects representing the values to format in the message.</param>
        void Fatal(Exception exception, string message, params object[] args);
    }
}
