using System;

namespace GLOCart.Domain
{
    public class EmailerType : Entity
    {
        public int Id { get; set; }

        public EmailType EmailType { get; set; }

        public string EmailText { get; set; }

    }
}

public enum EmailType {
    SendToExpert,
    ScheduleAdded,
    ScheduleInvite
}
