using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication.Models
{
    [Bind(Exclude = "StateDropDown")]
    public class Address
    {
        [Display(Name = "City", Prompt = "City..."), Required]
        public String City { get; set; }

        [Display(Name = "State"), Required]
        public String State { get; set; }

        [Display(Name = "Zip", Prompt = "Zip"), Required]
        public String Zip { get; set; }

        public IEnumerable<SelectListItem> StateDropDown { get; set; }
    }
}