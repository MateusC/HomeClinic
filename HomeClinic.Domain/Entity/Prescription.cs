using System;

namespace HomeClinic.Domain.Entity
{
    public class Prescription : Entity
    {
        public virtual Account Account { get; set; }
        public virtual Pet Pet{ get; set; }
        public virtual DateTime Date { get; set; }
    }
}
