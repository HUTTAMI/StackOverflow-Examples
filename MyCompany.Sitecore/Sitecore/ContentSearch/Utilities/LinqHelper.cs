using Sitecore.ContentSearch.Linq.Common;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.ContentSearch.Utilities
{
    public static class LinqHelper
    {
#if SC72
        [Obsolete("Please use 'IQueryable<T> CreateQuery<T>(IProviderSearchContext context, IEnumerable<SearchStringModel> searchStringModel)' method instead.")]
#endif
        public static IQueryable<SitecoreUISearchResultItem> CreateQuery(IProviderSearchContext context, IEnumerable<SearchStringModel> searchStringModel)
        {
            return CreateQuery<SitecoreUISearchResultItem>(context, searchStringModel);
        }

        public static IQueryable<T> CreateQuery<T>(IProviderSearchContext context, IEnumerable<SearchStringModel> searchStringModel)
            where T : ISearchResult
        {
            return CreateQuery<T>(context, searchStringModel, new Item(), null);
        }

        public static IQueryable<T> CreateQuery<T>(IProviderSearchContext context, IEnumerable<SearchStringModel> searchStringModel, Item startLocationItem, IEnumerable<IExecutionContext> additionalContexts = null) 
            where T : ISearchResult
        {
            return Enumerable.Empty<T>().AsQueryable<T>();
        }
    }
}
