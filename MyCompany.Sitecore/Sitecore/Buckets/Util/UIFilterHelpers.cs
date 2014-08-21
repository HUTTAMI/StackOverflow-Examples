using Sitecore.ContentSearch.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Buckets.Util
{
    // small example showing how we can change this file based on version:
    public class UIFilterHelpers
    {
#if SC72
        [Obsolete("Use SearchStringModel.ParseDatasourceString instead")]
#endif
        public static IEnumerable<SearchStringModel> ParseDatasourceString(String queryString)
        {
            return Enumerable.Empty<SearchStringModel>();
        }
    }
}
