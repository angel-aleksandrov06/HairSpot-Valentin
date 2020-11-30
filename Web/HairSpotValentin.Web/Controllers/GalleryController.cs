namespace HairSpotValentin.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using HairSpotValentin.Services.Data.Gallery;
    using Microsoft.AspNetCore.Mvc;

    public class GalleryController : BaseController
    {
        private readonly IGalleriesService galleriesService;

        public GalleryController(IGalleriesService galleriesService)
        {
            this.galleriesService = galleriesService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
