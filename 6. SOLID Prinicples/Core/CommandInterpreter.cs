
namespace LoggerT.Core
{

    using LoggerT.Appenders.Contracts;
    using LoggerT.Core.Contracts;
    using LoggerT.Layouts.Contracts;
    using LoggerT.Loggers;
    using System;
    using System.Collections.Generic;

    public class CommandInterpreter : ICommandInterpreter
    {
        private List<IAppender> appenders;
        private ILayoutFactory layoutFactory;
        private IAppenderFactory appenderFactory;


        public CommandInterpreter(ILayoutFactory layoutFactory, IAppenderFactory appenderFactory)
        {
            this.appenders = new List<IAppender>();
            this.layoutFactory = layoutFactory;
            this.appenderFactory = appenderFactory;
        }

        public void AddAppender(params string[] args)
        {
            string typeAppender = args[0];
            string typeLayout = args[1];

            ILayout currentLayout = layoutFactory.GenerateLayout(typeLayout);

            ReportLevel level = ReportLevel.INFO;

            if (args.Length==3)
            {
                Enum.TryParse(args[2],true, out ReportLevel lvl);

                level = lvl;
            }

            IAppender appender = appenderFactory.GenerateFactory(typeAppender, currentLayout, level);

            appenders.Add(appender);

        }

        public void AddMessage(params string[] args)
        {

            ReportLevel report = Enum.Parse<ReportLevel>(args[0]);

            string date = args[1];
            string message = args[2];


            foreach (var ap in appenders)
            {
                ap.AppendLine(date,report,message);
            }

           
        }

        public void Print()
        {
            foreach (var ap in appenders)
            {
                Console.WriteLine(ap);
            }
        }

        
    }
}
