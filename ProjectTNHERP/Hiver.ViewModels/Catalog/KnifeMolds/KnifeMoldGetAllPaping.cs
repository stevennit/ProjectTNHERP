using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMolds
{
    public class KnifeMoldGetAllPaping : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
