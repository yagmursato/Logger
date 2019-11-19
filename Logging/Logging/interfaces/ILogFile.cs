using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.interfaces
{
    public interface ILogFile
    {
        int Size { get; }
        void Write(string content);
    }
}
