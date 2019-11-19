using Logging.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Model
{
    public class Logger:ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }
        public ICollection<IAppender> Appenders { get; set; }
        public void Info(string date, string msg)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(date, ReportLevel.INFO, msg);
            }
        }
        public void Warning(string date, string msg)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(date, ReportLevel.WARNING, msg);
            }
        }
        public void Error(string date, string msg)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(date, ReportLevel.ERROR, msg);
            }
        }
        public void Critical(string date, string msg)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(date, ReportLevel.CRITICAL, msg);
            }
        }
        public void Fatal(string date, string msg)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(date, ReportLevel.FATAL, msg);
            }
        }
    }
}
