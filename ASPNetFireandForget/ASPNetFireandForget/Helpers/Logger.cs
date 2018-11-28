using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ASPNetFireandForget.Helpers
{
    public class Logger
    {
        private ILog Log;

        private static Logger _Current;

        public static Logger Current
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new Logger();
                }
                return _Current;
            }
        }

        public Logger()
        {
            Log = LogManager.GetLogger("AMN_PNSender");
        }

        public void Info(string logString, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            Log.Info(logString);
        }

        public void Error(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            Log.Error(ex);
        }

        public void Warning(string logString, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            Log.Warn(logString);
        }
    }
}