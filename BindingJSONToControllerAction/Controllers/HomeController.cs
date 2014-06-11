using BindingJSONToControllerAction.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BindingJSONToControllerAction.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Example()
        {
            ViewBag.Message = "Binding JSON data to Action on Controller";

            return View();
        }

        [HttpPost]
        public JsonResult Example(IList<MyModel> models)
        {
            if (ModelState.IsValid)
            {
                return Json(new { models = models });
            }
            return Json(new { error = true, message = "ModelState is invalid" });
        }
    }
}