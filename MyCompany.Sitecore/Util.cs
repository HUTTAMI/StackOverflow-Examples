using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is a shared class that may be commonly implemented across all Sitecore versions.
 * Nothing in this file should be too version-specific.
 * However, because each project has an SC# symbol defined, we can integrate tiny changes
 * within the class if we so choose.
 */

namespace MyCompany
{
    public partial class Util
    {
        public Item GetHomeItem()
        {
            return Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
        }

        public IEnumerable<Item> GetDatasourceItems(String datasource, Item item = null)
        {
            IIndexable indexable = (SitecoreIndexableItem)(item ?? Sitecore.Context.Item);
            try
            {
                using (IProviderSearchContext context = ContentSearchManager.CreateSearchContent(indexable))
                {
                    IEnumerable<SearchStringModel> searchStringModel =
#if !SC72
                        Sitecore.Buckets.Util.UIFilterHelpers.ParseDatasourceString(datasource);
#else
                        Sitecore.ContentSearch.Utilities.SearchStringModel.ParseDatasourceString(datasource);
#endif
                    IQueryable<SitecoreUISearchResultItem> queryable =
#if !SC72
                        LinqHelper.CreateQuery(context, searchStringModel);
#else
                        LinqHelper.CreateQuery<SitecoreUISearchResultItem>(context, searchStringModel);
#endif
                    return (from i in queryable select i.GetItem());
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
