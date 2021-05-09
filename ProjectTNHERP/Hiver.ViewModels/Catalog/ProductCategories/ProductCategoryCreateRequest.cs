using Hiver.Utilities.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class ProductCategoryCreateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string CreateBy { get; set; }
        public Status Status { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}
