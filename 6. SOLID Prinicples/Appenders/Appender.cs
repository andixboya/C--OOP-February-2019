
namespace LoggerT.Appenders
{
    using LoggerT.Appenders.Contracts;
    using LoggerT.Layouts.Contracts;
    using LoggerT.Loggers;


    public abstract class Appender : IAppender
    {

        public ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;

        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void AppendLine(string date, ReportLevel error, string message);

        protected int MessageCount { get; set; }


        public bool IsAboveLevel(ReportLevel report)
        {

            if (report >= this.ReportLevel)
            {
                return true;
            }

            return false;
        }

      

    }
}
