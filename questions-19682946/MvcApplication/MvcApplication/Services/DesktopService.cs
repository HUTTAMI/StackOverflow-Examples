using System.Collections.Generic;
using MvcApplication.Models.Shared;

namespace MvcApplication.Services
{
    public class DesktopService
    {
        public IEnumerable<Person> GetPersons()
        {
            return new[]{
                new Person { Name = "Ashley" },
                new Person { Name = "Bob" },
                new Person { Name = "Chloe" },
                new Person { Name = "David" },
                new Person { Name = "Eli" },
                new Person { Name = "Frank" },
                new Person { Name = "Geraldine" }
            };
        }

        public IEnumerable<Place> GetPlaces()
        {
            return new[]{
                new Place { Name = "Alabama" },
                new Place { Name = "Alaska" },
                new Place { Name = "Arizona" },
                new Place { Name = "Arkansas" },
                new Place { Name = "California" },
                new Place { Name = "Colorado" },
                new Place { Name = "Connecticut" }
            };
        }
    }
}