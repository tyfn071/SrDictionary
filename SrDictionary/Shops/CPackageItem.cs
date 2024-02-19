using SrDictionary.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrDictionary.Shops
{
    public sealed class PackageItem : Obj
    {
        public PackageItem() : base()
        {
            ExpandTerm = "EXPAND_TERM_ALL";
        }
        [SParam("@saletag", System.Data.SqlDbType.SmallInt)]
        public short SaleTag { get; set; }
        [SParam("@expandterm", System.Data.SqlDbType.VarChar, 129)]
        public string? ExpandTerm { get; set; }
        [SParam("@icon", System.Data.SqlDbType.VarChar, 129)]
        public string? AssocFileIcon { get; set; }

    }
}
