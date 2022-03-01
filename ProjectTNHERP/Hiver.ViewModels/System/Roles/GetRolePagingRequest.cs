using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.System.Roles
{
    public class GetRolePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}