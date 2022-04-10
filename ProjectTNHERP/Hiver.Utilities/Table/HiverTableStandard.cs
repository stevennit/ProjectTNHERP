using System;

namespace Hiver.Utilities.Table
{
    public interface HiverTableStandard
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
