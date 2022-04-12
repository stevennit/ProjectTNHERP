using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> ProductCategories { get; set; } = new List<SelectItem>();
    }
}
