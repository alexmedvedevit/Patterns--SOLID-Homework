using System;
using System.Globalization;

namespace Logger.Solution
{
    public class JsonLayout : ILayout
    {
        public string SetMsgFormat(string messageType, string time, string msg)
        {
            
            return "{\n    'messageType': "+messageType+";\n    'time': "+time+";\n    'messageText': "+msg+";\n}";
        }
    }
}