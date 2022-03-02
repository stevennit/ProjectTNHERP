using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMoldCategories
{
    public class KnifeMoldCategoryCreateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Status Status { get; set; }

        public List<string> KnifeMold { get; set; } = new List<string>();
    }
}
