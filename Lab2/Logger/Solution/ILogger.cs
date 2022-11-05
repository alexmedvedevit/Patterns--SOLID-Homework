namespace Logger.Solution
{
    public interface ILogger
    {
        public void Info(string time, string msg);
        public void Error(string time, string msg);
    }
}