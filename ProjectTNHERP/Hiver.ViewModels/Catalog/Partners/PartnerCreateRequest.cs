using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Partners
{
    public class PartnerCreateRequest : HiverTableCreate
    {
        public Gender? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public IFormFile Image { get; set; }

        public DateTime? DoB { get; set; }

        public bool Status { get; set; }

        public int? IdPartnerCategory { get; set; }


    }
}
