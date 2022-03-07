using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Utilities.Table
{
    public class HiverTableUpdate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được trống")]
        [Display(Name = "Tên")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
