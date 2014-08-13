using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class AdvisoryExpert
    {
        public int Id { get; set; }

        public int AdvisoryId { get; set; }

        public int ExpertId { get; set; }

        public WatcherType WatcherType { get; set; }

        public DateTime ExpertAddedOn { get; set; }

        public int ExpertAddedBy { get; set; }

        public bool IsRemoved { get; set; }

        public DateTime ExpertRemovedOn { get; set; }

        public int ExpertRemovedBy { get; set; }
    }

    public enum WatcherType
    {
        Author,
        Watcher
    }
}
