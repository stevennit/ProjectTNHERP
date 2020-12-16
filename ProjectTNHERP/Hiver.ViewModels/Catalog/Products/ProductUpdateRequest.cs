using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }

        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public string Status { get; set; }

        public IFormFile ThumbnailImage { get; set; }

    }
}
