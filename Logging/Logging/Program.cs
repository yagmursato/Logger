using Logging.Appender;
using Logging.interfaces;
using Logging.Layouts;
using Logging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
               int numberOfAppenders = Int32.Parse(Console.ReadLine());
               IAppender[] appenders = new IAppender[numberOfAppenders];
               for (int i = 0; i < numberOfAppenders; i++)
               {
                    string[] words = Console.ReadLine().Split(' ');
                    IAppender appender = AppenderFactory.CreateAppender(words[0],words[1]);
                    
                    if (words.Length > 2)
                    {
                        ReportLevel level = (ReportLevel)Enum.Parse(typeof(ReportLevel), words[2]);
                        appender.ReportLevel = level;
                    }
                    appenders[i] = appender;
                }
                var logger = new Logger(appenders);
                string commandInput;
                while ((commandInput = Console.ReadLine()).ToLower() != "end" )
                {
                    var words = commandInput.Split('|');
                    string time = words[1];
                    string msg = words[2];

                    ReportLevel level = (ReportLevel)Enum.Parse(typeof(ReportLevel), words[0]);

                    switch (level)
                    {
                        case ReportLevel.CRITICAL:
                            logger.Critical(time, msg);
                            break;
                        case ReportLevel.ERROR:
                            logger.Error(time, msg);
                            break;
                        case ReportLevel.FATAL:
                            logger.Fatal(time, msg);
                            break;
                        case ReportLevel.INFO:
                            logger.Info(time, msg);
                            break;
                        case ReportLevel.WARNING:
                            logger.Warning(time, msg);
                            break;
                    }
                }

                Console.WriteLine(logger);
                Console.ReadLine();

            }
    }
}
