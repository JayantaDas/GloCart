using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GLOCart.DAL.DBEntities;

namespace GLOCart.Domain
{
    public class Advisory :Entity
    {
        public int AdvisoryId { get; set; }

        public string AdvisoryName { get; set; }

        public string AdvisoryDescription { get; set; }
        
        public string AdvisoryImagePath { get; set; }

        public int AdvisoryCreatedBy { get; set; }
        
        public DateTime AdvisoryCreationDate { get; set; }
                
        //public float Version { get; set; }

        public IEnumerable<AdvisoryDocument> AdvisoryDocuments { get; set; }

        public IEnumerable<AdvisoryExpert> AdvisoryExperts { get; set; }

        public IEnumerable<AdvisoryWatch> AdvisoryWatchers { get; set; }

        public int? AdvisoryModifiedBy { get; set; }

        public DateTime? AdvisoryModifiedDate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionDate { get; set; }

        public int? DeletedBy { get; set; }
    }

}
