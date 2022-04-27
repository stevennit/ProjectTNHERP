using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Guid? CategoryId { get; set; }

    }
}
