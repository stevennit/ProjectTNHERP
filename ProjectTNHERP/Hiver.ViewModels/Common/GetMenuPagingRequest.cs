using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Common
{
    public class GetMenuPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
