using Logging.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Layouts
{
       public class SimpleLayout : ILayout
       {
           public string Format => "{0} - {1} - {2}";
       }
}
