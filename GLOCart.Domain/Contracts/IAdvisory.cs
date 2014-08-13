using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain.Contracts
{
    public interface IAdvisory
    {
        IEnumerable<Advisory> GetAllAdvisories();

        Advisory GetAdvisory(int advisoryId);

        IEnumerable<AdvisoryDocument> GetAdvisoryDocuments(int advisoryId);

        IEnumerable<AdvisoryDocumentTag> GetAdvisoryDocumentTags(int advisoryId, int documentId);

        IEnumerable<AdvisoryExpert> GetAdvisoryexperts(int advisoryId);

        IEnumerable<AdvisoryWatch> GetAdvisoryWatchers(int advisoryId);
        
        int AddAdvisory(Advisory advisory);

        void ModifyAdvisory(Advisory advisory);

        int AddAdvisoryWatch(AdvisoryWatch advisoryWatch);

        void removeAdvisoryWatch(AdvisoryWatch advisoryWatch);

    }
}
