using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        [HttpPost]
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.searchword = searchTerm;
            ViewBag.columns = ListController.columnChoices;
            List<Dictionary<string, string>> jobs = new List<Dictionary<string, string>>();

            if (searchType.Equals("all"))
            {
                if (searchTerm == null)
                {
                    jobs = JobData.FindAll();
                } else
                {
                    jobs = JobData.FindByValue(searchTerm);
                }

            }
            else
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            ViewBag.jobs = jobs;

            return View("Index");
        }

    }
}
