using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WorldJourney.Filters
{
    public class LogActionFilterAttribute : ActionFilterAttribute
    {
        private IHostingEnvironment _environment { get; set; }
        private string _contentRootPath { get; set; }
        private string _logPath { get; set; }
        private string _fileName { get; set; }
        private string _fullPath { get; set; }

        public LogActionFilterAttribute(IHostingEnvironment environment)
        {
            _environment = environment;
            _contentRootPath = _environment.ContentRootPath;
            _logPath = _contentRootPath + "'LogFile'";
            _fileName = $"log{DateTime.Now.ToString("MM-dd-yyyy-H-mm")}.txt";
            _fullPath = _logPath + _fileName;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Directory.CreateDirectory(_logPath);

            string actionName;
            string controllerName;
            actionName = filterContext.ActionDescriptor.RouteValues["action"];
            controllerName = filterContext.ActionDescriptor.RouteValues["controller"];

            using (FileStream fs = new FileStream(_fullPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"The action {actionName} in {controllerName} controller started, event fired: OnActionExecuting");
                }
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string actionName;
            actionName = filterContext.ActionDescriptor.RouteValues["action"];
            string controllerName;
            controllerName = filterContext.ActionDescriptor.RouteValues["controller"];

            using (FileStream fs = new FileStream(_fullPath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"The action {actionName} in {controllerName} controller finished, event fired: OnActionExecuted");
                }
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string actionName;
            actionName = filterContext.ActionDescriptor.RouteValues["action"];
            string controllerName;
            controllerName = filterContext.ActionDescriptor.RouteValues["controller"];
            ViewResult result;
            result = (ViewResult)filterContext.Result;

            using (FileStream fs = new FileStream(_fullPath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"The action {actionName} in {controllerName} controller has the following viewData:  {result.ViewData.Values.FirstOrDefault()}, event fired : OnResultExecuted");
                }
            }
        }

    }
}