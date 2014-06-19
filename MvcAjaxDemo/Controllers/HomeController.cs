using System.Web.Mvc;

namespace MvcAjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult Ajax()
        {
            return PartialView();
        }
    }
}