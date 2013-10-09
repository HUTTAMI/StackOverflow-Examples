using System;
using System.Web.Mvc;
using MvcApplication.Models.Home;
using MvcApplication.Services;
using PagedList;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectService projectService;

        public HomeController()
        {
            this.projectService = new ProjectService();
        }

        public ActionResult Index(Int32 page = 1)
        {
            IndexVM model = new IndexVM
            {
                Projects = this.projectService.GetProjects().ToPagedList(page, 6)
            };
            return View(model);
        }
    }
}
