using MvcApplication.Models.Shared;
using PagedList;

namespace MvcApplication.Models.Home
{
    public class IndexVM
    {
        public IPagedList<ProjectVM> Projects { get; set; }
    }
}