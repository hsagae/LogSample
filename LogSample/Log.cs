using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace LogSample
{
    public class Log
    {
        private static ILog logger = null;

        public static ILog getLogger()
        {
            if (logger == null)
            {
                logger = LogManager.GetLogger(@"LogSample");
            }

            return logger;
        }
        
    }
}
