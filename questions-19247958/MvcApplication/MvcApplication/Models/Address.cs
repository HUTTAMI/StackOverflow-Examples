using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcApplication.Models
{
    public class Address
    {
        public String City { get; set; }
        public String Zip { get; set; }

        public IEnumerable<SelectListItem> CityDropDown { get; set; }
    }
}