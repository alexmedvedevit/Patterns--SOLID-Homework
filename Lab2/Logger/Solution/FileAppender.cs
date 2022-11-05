using System;
using System.IO;

namespace Logger.Solution
{
    public class FileAppender : IAppender
    {
        private ILayout layout { get; set; }
        private LogFile file { get; set; }

        public FileAppender(ILayout layout, LogFile file)
        {
            this.layout = layout;
            this.file = file;
        }

        public void WriteMessage(string msgType, string time, string msg)
        {
            string stringToWrite = layout.SetMsgFormat(msgType, time, msg);
            using (StreamWriter writer = new StreamWriter(this.file.Name, false))
            {
                writer.WriteLineAsync(stringToWrite);
            }
        }
        
    }
}