using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.interfaces
{
    interface ILogger
    {
        ICollection<IAppender> Appenders { get; }

        void Info(string date, string msg);
        void Warning(string date, string msg);
        void Error(string date, string msg);
        void Critical(string date, string msg);
        void Fatal(string date, string msg);


    }
}
