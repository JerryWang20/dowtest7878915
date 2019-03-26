using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dow.dowtest7878915.Common
{
    public static class ClientLogger
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(Constants.ClientLoggerName);

        public static void WriteError(string message)
        {
            log.Error(message);
        }

    }
}
