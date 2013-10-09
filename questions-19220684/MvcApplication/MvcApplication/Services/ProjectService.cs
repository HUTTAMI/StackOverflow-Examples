using System.Collections.Generic;
using MvcApplication.Models.Shared;

namespace MvcApplication.Services
{
    public class ProjectService
    {
        public IEnumerable<ProjectVM> GetProjects()
        {
            // Dummy service just to show content
            return new[]{
                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },
                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },
                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },

                // Different orders to show 5 more pages
                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },
                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },
                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },

                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },
                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },
                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" },
                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },

                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },
                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },
                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },

                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },
                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },
                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },

                new ProjectVM { Image = "microsoft_it.png", Name = "Microsoft IT" },
                new ProjectVM { Image = "life_positive.png", Name = "Life Positive" },
                new ProjectVM { Image = "inote.png", Name = "iNote" },
                new ProjectVM { Image = "call.png", Name = "Call!" },
                new ProjectVM { Image = "abc_letters.png", Name = "ABC Letters" },
                new ProjectVM { Image = "amazon_mobile.png", Name = "Amazon Mobile" }
            };
        }
    }
}