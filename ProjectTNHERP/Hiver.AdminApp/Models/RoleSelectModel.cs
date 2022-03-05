using System.Collections.Generic;

namespace Hiver.AdminApp.Models
{
    public class RoleSelectModel
    {
        public RoleSelectModel()
        {
            RoleNameList = new List<Itemlist>() {
                new Itemlist { Text = "Khushbu", Value = 1 },
                new Itemlist { Text = "Mohan", Value = 2 },
                new Itemlist { Text = "John", Value = 3 },
                new Itemlist { Text = "Martin", Value = 4 },
                new Itemlist { Text = "Due", Value = 5 },
                };

            RolePositionList = new List<Itemlist>() {
                new Itemlist { Text = "Khushbu", Value = 1 },
                new Itemlist { Text = "Mohan", Value = 2 },
                new Itemlist { Text = "John", Value = 3 },
                new Itemlist { Text = "Martin", Value = 4 },
                new Itemlist { Text = "Due", Value = 5 },
                };
        }

        public int RoleNameListId { get; set; }

        public List<Itemlist> RoleNameList { get; set; }
        public List<Itemlist> RolePositionList { get; set; }
    }
}
