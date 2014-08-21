using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.ContentSearch.Utilities
{
    public class SearchStringModel
    {
#if SC72
        public static IEnumerable<SearchStringModel> ParseDatasourceString(String queryString)
        {
            return Enumerable.Empty<SearchStringModel>();
        }
#endif
    }
}
