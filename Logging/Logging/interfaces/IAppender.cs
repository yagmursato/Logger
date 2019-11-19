using Logging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logging.Model.ReportLevel;

namespace Logging.interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(string date, ReportLevel level, string message);

        ReportLevel ReportLevel { get; set; }
    }
}
