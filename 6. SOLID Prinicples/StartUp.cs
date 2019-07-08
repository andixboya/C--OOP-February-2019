
namespace LoggerT
{
    using LoggerT.Appenders.Contracts;
    using LoggerT.Appenders.Factories;
    using LoggerT.Core;
    using LoggerT.Core.Contracts;
    using LoggerT.Layouts.Contracts;
    using LoggerT.Layouts.Factories;

    public class StartUp
    {
        public static void Main(string[] args)
        {


            ILayoutFactory layoutFactory = new LayoutFactory();
            IAppenderFactory appenderFactory = new AppenderFactory();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(layoutFactory,appenderFactory);

            IEngine engine = new Engine(commandInterpreter);
            engine.Run();


        }
    }
}
