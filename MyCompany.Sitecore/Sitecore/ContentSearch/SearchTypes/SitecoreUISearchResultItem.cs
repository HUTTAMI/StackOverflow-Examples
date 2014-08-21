using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.ContentSearch.SearchTypes
{
    public class SitecoreUISearchResultItem : UISearchResult
    {
        public Item GetItem()
        {
            return new Item();
        }
    }
}
