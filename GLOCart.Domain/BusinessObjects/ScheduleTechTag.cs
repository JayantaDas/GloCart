using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class ScheduleTechTag
    {
        public int TagId { get; set; }

        public int ScheduleId { get; set; }

        public int TechId { get; set; }

        public DateTime TaggedOn { get; set; }

        public int TaggedBy { get; set; }

        public bool IsTagDeleted { get; set; }

        public DateTime? TagDeletionDate { get; set; }

        public int? TagDeletedBy { get; set; }
    }
}
