using Hiver.Utilities.Table;
using Hiver.ViewModels.Catalog.ProductImages;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductCreateRequest : HiverTableCreate
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
