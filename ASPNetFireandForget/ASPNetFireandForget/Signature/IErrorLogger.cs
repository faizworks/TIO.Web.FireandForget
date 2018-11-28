using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace ASPNetFireandForget.Signature
{
    public interface IErrorLogger
    {
        Task LogError(string Title, Exception ex);
        Task LogError(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        Task ShowAndLogError(string Title, Exception ex);
        Task ShowAndLogError(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        Task ShowToastAndLogError(string toastMessage, Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
    }
}