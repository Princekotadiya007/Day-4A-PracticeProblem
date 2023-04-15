using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    internal class Nlogs
    {
        public static readonly Logger logger =
           LogManager.GetCurrentClassLogger();
        public void Loginfo(string msg)
        {
            logger.Info(msg);
        }
        public void Logdebug(string msg)
        {
            logger.Debug(msg);
        }
        public void Logerror(string msg)
        {
            logger.Error(msg);
        }
    }
}
