using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public Guid? ProductCategoryId { get; set; }
    }
}
