using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest : HiverTableUpdate
    {
        public string Code { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }


        public bool Status { get; set; }
        public int? ViewCount { get; set; }

        public IFormFile ThumbnailImage { get; set; }

        public List<Guid> ProductCategories { get; set; }
    }
}
