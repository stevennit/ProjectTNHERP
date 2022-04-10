using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Partners
{
    public class GetPartnerPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
