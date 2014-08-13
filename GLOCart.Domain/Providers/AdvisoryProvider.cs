using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLOCart.Domain;
using GLOCart.Domain.Contracts;

namespace GLOCart.Domain.Providers
{
    public class AdvisoryProvider: IAdvisory
    {
        public IEnumerable<Advisory> GetAllAdvisories()
        {
            throw new NotImplementedException();
        }

        public Advisory GetAdvisory(int advisoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvisoryDocument> GetAdvisoryDocuments(int advisoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvisoryDocumentTag> GetAdvisoryDocumentTags(int advisoryId, int documentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvisoryExpert> GetAdvisoryexperts(int advisoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdvisoryWatch> GetAdvisoryWatchers(int advisoryId)
        {
            throw new NotImplementedException();
        }

        public int AddAdvisory(Advisory advisory)
        {
            throw new NotImplementedException();
        }

        public void ModifyAdvisory(Advisory advisory)
        {
            throw new NotImplementedException();
        }

        public int AddAdvisoryWatch(AdvisoryWatch advisoryWatch)
        {
            throw new NotImplementedException();
        }

        public void removeAdvisoryWatch(AdvisoryWatch advisoryWatch)
        {
            throw new NotImplementedException();
        }
    }
}
