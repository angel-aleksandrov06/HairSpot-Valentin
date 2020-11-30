namespace HairSpotValentin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using HairSpotValentin.Data.Common.Models;

    public class GalleryCategory : BaseDeletableModel<int>
    {
        public GalleryCategory()
        {
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
