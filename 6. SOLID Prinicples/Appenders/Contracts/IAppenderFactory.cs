

namespace LoggerT.Appenders.Contracts
{
    using LoggerT.Layouts.Contracts;
    using LoggerT.Loggers;

    public interface IAppenderFactory
    {
        IAppender GenerateFactory(string type, ILayout layout, ReportLevel level);

    }
}
