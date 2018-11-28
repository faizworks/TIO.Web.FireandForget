using ASPNetFireandForget.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace ASPNetFireandForget.Helpers
{
    public class ErrorLogger : IErrorLogger
    {
        private static ErrorLogger _Current;
        public static ErrorLogger Current
        {
            get
            {
                if (_Current == null)
                    return new ErrorLogger();
                return _Current;
            }
        }

        public async Task LogError(string Title, Exception ex)
        {
            System.Diagnostics.Debug.Write(Title + ": " + ex.ToString());
        }

        public async Task LogError(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            System.Diagnostics.Debug.Write(ex);
        }

        public async Task ShowAndLogError(string Title, Exception ex)
        {
            System.Diagnostics.Debug.Write(Title + ": " + ex.ToString());
        }

        public async Task ShowAndLogError(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            System.Diagnostics.Debug.Write(ex);
        }

        public async Task ShowToastAndLogError(string toastMessage, Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            System.Diagnostics.Debug.Write(ex);
        }
    }
}