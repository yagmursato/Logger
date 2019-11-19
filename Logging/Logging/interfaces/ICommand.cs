using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.interfaces
{
    public interface ICommand
    {
        void ParseCommand(string appender, string layout, string reportLevel);
    }
}
