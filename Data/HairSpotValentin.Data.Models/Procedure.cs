namespace HairSpotValentin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using HairSpotValentin.Data.Common.Models;

    public class Procedure : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public TimeSpan TimeInterval { get; set; }
    }
}
