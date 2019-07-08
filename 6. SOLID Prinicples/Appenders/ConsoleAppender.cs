


namespace LoggerT.Appenders
{
    using LoggerT.Layouts.Contracts;
    using LoggerT.Loggers;
    using System;

    public class ConsoleAppender :Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void AppendLine(string date, ReportLevel error, string message)
        {

            if (IsAboveLevel(error))
            {
                Console.WriteLine(string.Format(this.layout.Format, date, error, message));
                this.MessageCount++;
               
            }
        }


        

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCount}";
        }
    }
}
