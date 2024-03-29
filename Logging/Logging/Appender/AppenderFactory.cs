﻿using Logging.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Appender
{
    public class AppenderFactory
    {
        public static IAppender CreateAppender(string appenderName, string layoutName)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var layoutType = types.FirstOrDefault(t => t.Name == layoutName);
            var appenderType = types.FirstOrDefault(t => t.Name == appenderName);

            var layout = (ILayout)Activator.CreateInstance(layoutType);
            var appender = (IAppender)Activator.CreateInstance(appenderType, new object[] { layout });

            return appender;
        }
    }
}
