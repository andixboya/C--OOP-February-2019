

namespace LoggerT.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(params string[] args);

        void AddMessage(params string[] args);

        void Print();



    }
}
