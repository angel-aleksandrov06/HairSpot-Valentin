namespace HairSpotValentin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using HairSpotValentin.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Path { get; set; }

        public string Extension { get; set; }

        public GalleryCategory Category { get; set; }

        public string CategoryId { get; set; }
    }
}
