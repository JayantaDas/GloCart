using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class Schedule : Entity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int AdvisoryId { get; set; }

        public DateTime ScheduleDateTime { get; set; }

        public ScheduleStatus Status { get; set; }

        public int LocationId { get; set; }

        public IEnumerable<ScheduleTechTag> TechnologyTagged { get; set; }

        public IEnumerable<ScheduleTechTag> ExpertTagged { get; set; }

        public IEnumerable<ScheduleAttendee> ScheduleAttendees { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public int? LastUpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}


public enum ScheduleStatus
{
    Upcoming,
    Ongoing,
    Cancelled
}