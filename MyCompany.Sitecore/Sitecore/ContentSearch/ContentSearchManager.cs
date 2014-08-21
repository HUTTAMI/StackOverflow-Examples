using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.ContentSearch
{
    public class ContentSearchManager
    {
        public static IProviderSearchContext CreateSearchContent(IIndexable indexable)
        {
            return new FooBarBazProvider.FooBarBazSearchContext();
        }
    }
}
