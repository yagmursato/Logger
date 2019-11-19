using Logging.Appender;
using Logging.interfaces;
using Logging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Appender
{
    public class ConsoleAppender : Appenders
    {
        public ConsoleAppender(ILayout layout)
            : base(layout) { }
        public override void Append(string date, ReportLevel level, string message)
        {
            if (level >= ReportLevel)
            {
                Console.WriteLine(String.Format(Layout.Format, date, level, message));
                this.Messages++;
            }
        }
    }
}
