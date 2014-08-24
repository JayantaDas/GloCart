using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class EmailerQueue
    {
        public int QueueId { get; set; }
        
        public int? ScheduleId { get; set;}
        
        public int? AdvisoryId { get; set; }
        
        public EmailerType EmailType { get; set; }
        
        public string SenderEmail {get; set;}

        public bool IsEmailSent { get; set; }

        public DateTime? DateEmailSent { get; set; }
    }
}
