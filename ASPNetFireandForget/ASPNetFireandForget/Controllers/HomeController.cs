using ASPNetFireandForget.Helpers;
using ASPNetFireandForget.Jobs;
using Nito.AspNetBackgroundTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetFireandForget.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            BackgroundTaskManager.Run(async () =>
            {
                try
                {
                    Logger.Current.Info("- Background task started");
                    var j = new Jobs.SampleJob();
                    await j.DoSomething(3, BackgroundTaskManager.Shutdown);
                }
                //catch (OperationCanceledException ex)
                //{
                //    Logger.Current.Error(new Exception("- Operation cancelled", ex));
                //}
                catch (Exception ex)
                {
                    Logger.Current.Error(ex);
                }
                finally
                {
                    Logger.Current.Info("- Background task ended");
                }
            });

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}