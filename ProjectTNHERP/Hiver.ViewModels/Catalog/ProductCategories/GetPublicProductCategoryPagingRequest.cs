using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class GetPublicProductCategoryPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
