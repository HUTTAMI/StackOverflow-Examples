using System;
using System.Linq;
using System.Web.Mvc;
using MvcApplication.Models.Desktop;
using MvcApplication.Services;

namespace MvcApplication.Controllers
{
    public class DesktopController : Controller
    {
        private readonly DesktopService desktopService;

        public DesktopController()
        {
            this.desktopService = new DesktopService();
        }

        //
        // GET: /Desktop/

        public ActionResult Index()
        {
            return View(new IndexVM
            {
                People = this.desktopService.GetPersons(),
                Places = this.desktopService.GetPlaces()
            });
        }

        //
        // GET: /Desktop/GetPersons
        public PartialViewResult GetPersons()
        {
            var persons = this.desktopService.GetPersons()
                .OrderBy(x => Guid.NewGuid()); // randomize to make it look like a refresh
            return PartialView("_PeoplePartial", persons);
        }

        //
        // GET: /Desktop/GetPlaces
        public PartialViewResult GetPlaces()
        {
            var places = this.desktopService.GetPlaces()
                .OrderBy(x => Guid.NewGuid()); // randomize to make it look like a refresh
            return PartialView("_PlacesPartial", places);
        }
    }
}
