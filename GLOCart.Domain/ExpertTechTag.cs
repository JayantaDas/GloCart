using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class ExpertTechTag
    {
        public int TagId { get; set; }

        public int ExpertId { get; set; }

        public int TechId { get; set; }

        public DateTime TaggedOn { get; set; }

        public int TaggedBy { get; set; }

        public bool IsTagDeleted { get; set; }

        public DateTime? TagDeletionDate { get; set; }

        public int? TagDeletedBy { get; set; }
    }
}
