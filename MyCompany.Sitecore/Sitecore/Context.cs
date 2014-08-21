using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Sites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore
{
    public static class Context
    {
        public static Database ContentDatabase { get { return new Database(); } }
        public static Database Database { get { return new Database(); } }
        public static Item Item { get { return new Item(); } }
        public static SiteContext Site { get { return new SiteContext(); } }
    }
}
