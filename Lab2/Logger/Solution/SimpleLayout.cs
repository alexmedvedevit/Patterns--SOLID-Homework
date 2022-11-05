using System;
using System.Globalization;

namespace Logger.Solution
{
    public class SimpleLayout : ILayout
    {
        public string SetMsgFormat(string messageType, string time, string msg)
        {
            return messageType+": "+time+" "+msg;
        }
    }
}