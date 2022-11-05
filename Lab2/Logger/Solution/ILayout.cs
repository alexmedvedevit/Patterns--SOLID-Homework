namespace Logger.Solution
{
    public interface ILayout
    {
        string SetMsgFormat(string messageType, string time, string msg);
    }
}