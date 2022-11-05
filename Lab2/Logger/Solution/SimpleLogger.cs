namespace Logger.Solution
{
    public class SimpleLogger : ILogger
    {
        public IAppender Appender { get; set; }
        public SimpleLogger(IAppender appender) => this.Appender = appender;
        public void Info(string time, string msg) => Appender.WriteMessage("Info", time, msg);
        public void Error(string time, string msg) => Appender.WriteMessage("Error", time, msg);
    }
}