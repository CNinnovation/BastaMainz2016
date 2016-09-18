using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    public static class LoggerExtensions
    {
        private static Action<ILogger, DateTimeOffset, Exception> _programStarting;
        static LoggerExtensions()
        {
            _programStarting = LoggerMessage.Define<DateTimeOffset>(LogLevel.Information, 1, "Starting at '{StartTime:t}'");
        }
        public static void ProgramStarting(this ILogger logger, DateTimeOffset startTime, Exception exception = null)
        {
            _programStarting(logger, startTime, exception);
        }
    }
}
