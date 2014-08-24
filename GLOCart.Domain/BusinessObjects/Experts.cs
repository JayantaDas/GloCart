using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GLOCart.Domain
{
    public class Experts : Entity
    {
        public int ExpertId { get; set; }

        public User User { get; set; }

        public IEnumerable<ExpertTechTag> ExpertTechTags { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletionDate { get; set; }
        
    }
}
