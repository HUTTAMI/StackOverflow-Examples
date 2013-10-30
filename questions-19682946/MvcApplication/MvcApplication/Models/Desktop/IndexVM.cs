using System.Collections.Generic;
using MvcApplication.Models.Shared;

namespace MvcApplication.Models.Desktop
{
    public class IndexVM
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Place> Places { get; set; }
    }
}