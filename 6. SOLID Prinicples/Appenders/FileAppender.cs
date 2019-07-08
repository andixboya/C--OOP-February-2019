
namespace LoggerT.Appenders
{

    using LoggerT.Layouts.Contracts;
    using LoggerT.LogFiles;
    using LoggerT.Loggers;
    using System;
    using System.IO;

    public class FileAppender : Appender
    {
        private LogFile file;
        private const string path = @"..\..\..\log.txt";


        public FileAppender(ILayout layout, LogFile file) 
            : base(layout)
        {
            this.file = file;
        }

    
        public override void AppendLine(string date, ReportLevel error, string message)
        {
            if (IsAboveLevel(error))
            {
                string info = string.Format(layout.Format, date, error, message);
                File.AppendAllText(path, info+ Environment.NewLine);
                
                this.MessageCount++;
                file.Write(info);
            }
            
        }


        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCount}, File size: {this.file.Size}";
        }

    }
}
