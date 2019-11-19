using Logging.interfaces;
using Logging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Appender
{
    public abstract class Appenders:IAppender
    {
        public Appenders(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel;
        }
        public int Messages { get; set; }
        public ReportLevel ReportLevel { get; set; }
        public ILayout Layout { get; set; }
        public abstract void Append(string date, ReportLevel level, string message);
        public override string ToString()
        {
            string formatYazi = $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.Messages}";
            return formatYazi;
        }

    }
}
