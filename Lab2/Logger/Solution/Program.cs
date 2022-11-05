using System;

namespace Logger.Solution
{
    public class Program
    {
        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            ILayout jsonLayout = new JsonLayout();
            
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            IAppender fileAppender = new FileAppender(jsonLayout, new LogFile("log.txt"));
            
            ILogger logger = new SimpleLogger(consoleAppender);
            logger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");

            ILogger loggerToFileOutput = new SimpleLogger(fileAppender);
            loggerToFileOutput.Info("11/4/2022 2:08:11 PM", "Happy Day of National Unity!");


        }
    }
}