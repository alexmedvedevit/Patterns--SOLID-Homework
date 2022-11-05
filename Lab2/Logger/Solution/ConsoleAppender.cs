using System;

namespace Logger.Solution
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout { get; set; }

        public ConsoleAppender(ILayout layout) => this.layout = layout;


        public void WriteMessage(string msgType, string time, string msg) => 
            Console.WriteLine(layout.SetMsgFormat(msgType,time,msg));
        
    }
}