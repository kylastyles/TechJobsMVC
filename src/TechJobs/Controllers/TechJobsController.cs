using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public override ViewResult View ()
        {
            return base.View();
        }
    }
}