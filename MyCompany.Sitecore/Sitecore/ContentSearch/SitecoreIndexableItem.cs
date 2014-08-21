using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.ContentSearch
{
    public class SitecoreIndexableItem : IIndexable
    {
        public static implicit operator SitecoreIndexableItem(Item item)
        {
            return new SitecoreIndexableItem();
        }
        public static implicit operator Item(SitecoreIndexableItem item)
        {
            return new Item();
        }
    }
}
