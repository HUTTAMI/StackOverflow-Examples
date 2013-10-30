using System;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    public class Person
    {
        [Display(Name = "Full Name", Prompt = "Name..."), Required]
        public String Name { get; set; }

        public Address Address { get; set; }
    }
}