namespace HairSpotValentin.Data.Models
{
    using HairSpotValentin.Data.Common.Models;

    public class AppointmentStatus : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
