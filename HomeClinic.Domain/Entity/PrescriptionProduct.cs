using System;

namespace HomeClinic.Domain.Entity
{
    public class PrescriptionProduct : Entity
    {
        public virtual Prescription Prescription { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual Decimal Amount { get; set; }
        public virtual String Unit { get; set; }
    }
}
