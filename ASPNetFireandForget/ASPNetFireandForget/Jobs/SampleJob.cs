using ASPNetFireandForget.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ASPNetFireandForget.Jobs
{
    public class SampleJob
    {
        public async Task DoSomething(int minutes, CancellationToken token)
        {
            Logger.Current.Info("- - Doing something started");
            int currentIteration = -1;
            try
            {
                var interation = ((minutes * 60) / 10);
                for (int i = 0; i < interation; i++)
                {
                    currentIteration = i;
                    Logger.Current.Info(string.Format("- - - Interation {0} started", currentIteration));
                    await Task.Delay(TimeSpan.FromSeconds(10));
                    Logger.Current.Info(string.Format("- - - Interation {0} finished", currentIteration));
                }
            }
            //catch (OperationCanceledException ex)
            //{
            //    Logger.Current.Error(new Exception("- - OperationCanceledException was thrown at iteration: " + currentIteration, ex));
            //    Logger.Current.Info("- - Trying to wind up in 30 seconds");
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Logger.Current.Info("- - - - OPeration cancelled iteration");
            //        await Task.Delay(TimeSpan.FromSeconds(5), token);
            //    }
            //    Logger.Current.Info("- - Trying to winded up in 30 seconds");
            //}
            finally
            {
                Logger.Current.Info("- - Doing something finished");
            }
        }
    }
}