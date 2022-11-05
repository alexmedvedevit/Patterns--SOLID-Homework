namespace Logger.Solution
{
    public interface IAppender
    {
        public void WriteMessage(string msgType, string time, string msg);
    }
}