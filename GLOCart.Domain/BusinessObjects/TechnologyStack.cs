using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class TechnologyStack :Entity
    {
        public int TechId { get; set; }

        public string TechName { get; set; }

        public string TechDesccription { get; set; }

        public int TechParentId { get; set; }

        public int TagType { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedBy { get; set; }

        public float Version { get; set; }
    }
}
