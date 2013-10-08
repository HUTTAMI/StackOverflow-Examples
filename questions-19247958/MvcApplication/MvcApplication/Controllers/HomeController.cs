using System.Text;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Person model = new Person()
            {
                Address = new Address
                {
                    CityDropDown = new SelectListItem[]{
                        new SelectListItem { Selected = true, Text = "Select one..." },
                        new SelectListItem { Text = "Anywhere", Value = "Anywhere" },
                        new SelectListItem { Text = "Somewhere", Value = "Somewhere" },
                        new SelectListItem { Text = "Nowhere", Value = "Nowhere" }
                    }
                }
            };
            return View(model);
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPOST(Person model)
        {
            if (ModelState.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Name: {0}", model.Name).AppendLine();
                sb.AppendFormat("Address: {0} {1}", model.Address.City, model.Address.Zip);
                return Content(sb.ToString());
            }
            return View(model);
        }
    }
}
