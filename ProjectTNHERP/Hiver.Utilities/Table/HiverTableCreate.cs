using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Utilities.Table
{
    public class HiverTableCreate
    {
        [Required(ErrorMessage = "Tên không được trống")]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }

    }
}
