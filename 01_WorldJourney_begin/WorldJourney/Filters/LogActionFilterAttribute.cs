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

        public IHostingEnvironment environment(IHostingEnvironment environment, string contentRootPath, string logPath, string fileName, string fullPath)
        {
            _environment = environment;
            _contentRootPath = _environment.ContentRootPath;
            _logPath = _contentRootPath + "'LogFile'";
            _fileName = @"log?DateTime.Now.ToString("MM-dd-yyyy-H-mm")-.txt";
        }

    }
}
