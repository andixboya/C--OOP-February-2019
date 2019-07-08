

namespace LoggerT.Loggers
{
    using LoggerT.Appenders.Contracts;
    using LoggerT.Loggers.Contracts;

    public class Logger : ILogger
    {

        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.consoleAppender = consoleAppender;
            this.fileAppender = fileAppender;
        }


        public void Info(string dateTime, string message)
        {
            appendMessage(dateTime, ReportLevel.INFO, message);
        }



        public void Warning(string dateTime, string message)
        {

            appendMessage(dateTime, ReportLevel.WARNING, message);

        }

        public void Error(string dateTime, string message)
        {
            appendMessage(dateTime, ReportLevel.ERROR, message);

        }


        public void Critical(string dateTime, string message)
        {
            appendMessage(dateTime, ReportLevel.CRITICAL, message);

        }

        public void Fatal(string dateTime, string message)
        {
            appendMessage(dateTime, ReportLevel.FATAL, message);

        }



        private void appendMessage(string dateTime, ReportLevel level, string message)
        {
            this.consoleAppender?.AppendLine(dateTime, level, message);

            this.fileAppender?.AppendLine(dateTime, level, message);

        }


    }
}
