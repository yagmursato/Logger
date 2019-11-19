using Logging.interfaces;
using Logging.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Logging.Appender;

namespace Logging.Appender
{
    public class FileAppender : Appenders
    {
        public FileAppender(ILayout layout)
            : base(layout) { }
        public override void Append(string date, ReportLevel level, string message)
        {
            if (level >= ReportLevel)
            {
                Console.WriteLine(String.Format(Layout.Format, date, level, message));
                this.Messages++;
            }
        }
        public ILogFile File { get; set; }
        public override string ToString()
        {
            string stringB = base.ToString() + $", File size: {this.File.Size}";
            return stringB;
        }
    }
}
