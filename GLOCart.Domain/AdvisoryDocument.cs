using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class AdvisoryDocument :Entity
    {
        public int DocumentId { get; set; }
        
        public string DocumentName { get; set; }
        
        public string DocumentDescription { get; set; }

        public int AdvisoryId { get; set; }

        public DocumentType DocumentType { get; set; }

        public string DocumentPath { get; set; }

        public DateTime CreationDate { get; set; }

        public int AddedBy { get; set; }

        public IEnumerable<AdvisoryDocumentTag> DocumentTags { get; set; }

        public bool IsDeleted { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletionDate { get; set; }
        
    }

    public enum DocumentType{
        WordDocument,
        ExcelWorkBook,
        PDFDocument,
        Presentation,
        TextFile,
        HTMLFile
    }
}
