using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    public class Program
    {
        private static ILogger<Program> _logger;

        public static void Main(string[] args)
        {
            var settings = new FilterLoggerSettings();
            settings.Add("Microsoft", LogLevel.Warning);

            ILoggerFactory factory = new LoggerFactory()
                .WithFilter(new FilterLoggerSettings
                {
                    { "Microsoft", LogLevel.Warning },
                    { "LoggingSample.Program", LogLevel.Information }

                });
            factory.AddConsole();
            factory.AddDebug();
            _logger = factory.CreateLogger<Program>();

            _logger.LogInformation(1, "started at '{StartTime:T}'", DateTimeOffset.Now);
            _logger.ProgramStarting(DateTimeOffset.Now);

        }

    }
}
