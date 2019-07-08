

namespace LoggerT.Appenders.Factories
{
    using LoggerT.Appenders.Contracts;
    using LoggerT.Layouts.Contracts;
    using LoggerT.LogFiles;
    using LoggerT.Loggers;
    using System;

    public class AppenderFactory :IAppenderFactory
    {
        public IAppender GenerateFactory(string type, ILayout layout, ReportLevel level)
        {
            IAppender appender = null;

            switch (type)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout);
                    appender.ReportLevel = level;
                    break;

                case "FileAppender":
                    appender = new FileAppender(layout, new LogFile());
                    appender.ReportLevel = level;
                    break;

                default:
                    throw new ArgumentException("No such appender!");
            }

            return appender;
        }
    }
}
