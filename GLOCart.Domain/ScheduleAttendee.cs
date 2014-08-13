using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class ScheduleAttendee
    {
        public int Id { get; set; }

        public int ScheduleId { get; set; }

        public int UserId { get; set; }

        public AttendeeStatus Status { get; set; }

        public DateTime NominatedOn { get; set; }
    }
}

public enum AttendeeStatus
{
    Registered,
    Withdrawn
}
