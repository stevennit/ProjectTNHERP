using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductCreateRequest : HiverTableCreate
    {
        [Display(Name = "Ký hiệu")]
        public string Symbol { get; set; }

        [Display(Name = "Chiều rộng")]
        public Double Width { get; set; }

        [Display(Name = "Chiều cao")]
        public Double Height { get; set; }

        [Display(Name = "Nội dung")]
        public string Detail { get; set; }

        //public Status? Status { get; set; }

        [Display(Name = "Nội dung")]
        public IFormFile ThumbnailImage { get; set; }
    }
}
