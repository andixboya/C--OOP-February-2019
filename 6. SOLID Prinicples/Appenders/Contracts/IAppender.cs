

namespace LoggerT.Appenders.Contracts
{
    using LoggerT.Loggers;

    public interface IAppender
    {
        

        void AppendLine(string date, ReportLevel error, string message);

        bool IsAboveLevel(ReportLevel report);

        ReportLevel ReportLevel { get; set; }



    }
}
