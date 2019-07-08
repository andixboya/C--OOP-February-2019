

namespace LoggerT.LogFiles.Contracts
{
    public interface ILogFile
    {
         int Size { get; }

        void Write(string messsage);
    }
}
