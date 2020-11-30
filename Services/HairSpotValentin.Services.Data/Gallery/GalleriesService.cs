namespace HairSpotValentin.Services.Data.Gallery
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using HairSpotValentin.Data.Common.Repositories;
    using HairSpotValentin.Data.Models;

    public class GalleriesService : IGalleriesService
    {
        private readonly IDeletableEntityRepository<Image> repository;

        public GalleriesService(IDeletableEntityRepository<Image> repository)
        {
            this.repository = repository;
        }
    }
}
