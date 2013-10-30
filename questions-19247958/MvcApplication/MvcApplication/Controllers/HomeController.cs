using System;
using System.Collections.Generic;
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
                    StateDropDown = this.GetStates()
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

            model.Address.StateDropDown = this.GetStates();
            return View(model);
        }

        private IEnumerable<SelectListItem> GetStates()
        {
            yield return new SelectListItem { Value = String.Empty, Text = "Please select one...", Selected = true };
            yield return new SelectListItem { Value = "AL", Text = "Alabama" };
            yield return new SelectListItem { Value = "AK", Text = "Alaska" };
            yield return new SelectListItem { Value = "AZ", Text = "Arizona" };
            yield return new SelectListItem { Value = "AR", Text = "Arkansas" };
            yield return new SelectListItem { Value = "CA", Text = "California" };
            yield return new SelectListItem { Value = "CO", Text = "Colorodo" };
            yield return new SelectListItem { Value = "CT", Text = "Connecticut" };
            yield return new SelectListItem { Value = "DE", Text = "Delaware" };
            yield return new SelectListItem { Value = "FL", Text = "Florida" };
            yield return new SelectListItem { Value = "GA", Text = "Georgia" };
            yield return new SelectListItem { Value = "HI", Text = "Hawaii" };
            yield return new SelectListItem { Value = "ID", Text = "Idaho" };
            yield return new SelectListItem { Value = "IL", Text = "Illinois" };
        }
    }
}
