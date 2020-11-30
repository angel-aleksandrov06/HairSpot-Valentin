namespace HairSpotValentin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using HairSpotValentin.Data.Common.Models;

    public class Appointment : BaseDeletableModel<string>
    {
        public Appointment()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Procedures = new HashSet<Procedure>();
        }

        public DateTime Date { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public virtual ApplicationUser Worker { get; set; }

        public string WorkerId { get; set; }

        public virtual ApplicationUser Client { get; set; }

        public string ClientId { get; set; }

        public AppointmentStatus Status { get; set; }

        public int StatusId { get; set; }

        public virtual ICollection<Procedure> Procedures { get; set; }
    }
}
