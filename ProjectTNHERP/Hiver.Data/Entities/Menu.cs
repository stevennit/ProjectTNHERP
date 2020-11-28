using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class Menu
    {
        public string ID { get; set; }
        public string ParentID { get; set; }
        public string Content { get; set; }
        public string IconClass { get; set; }
        public string Url { get; set; }
        public long Order { get; set; }
    }
}
