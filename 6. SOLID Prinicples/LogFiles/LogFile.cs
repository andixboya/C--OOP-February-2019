

namespace LoggerT.LogFiles
{
    using LoggerT.LogFiles.Contracts;
    using System.Linq;

    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(c => char.IsLetter(c)).Sum(x=> x);
        }
    }
}
