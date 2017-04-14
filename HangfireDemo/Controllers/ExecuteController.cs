using Hangfire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HangfireDemo.Controllers
{
    public class ExecuteController : Controller
    {
        // GET: Execute
        public ActionResult Index()
        {
            //基于队列的任务处理
            var jobId = BackgroundJob.Enqueue(() => Con());
            //延迟任务执行
            var jobId2 = BackgroundJob.Schedule(() => Console.Write("延迟5分钟"), TimeSpan.FromMinutes(5));
            //定时任务
            RecurringJob.AddOrUpdate(() => Console.Write("定时任务"), Cron.Minutely);
            return View();
        }
        [DisplayName("输出")]
        public void Con()
        {
            Console.Write("zhangsan");
        }
    }
}