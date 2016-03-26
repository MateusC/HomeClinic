using System;

namespace HomeClinic.Domain.Entity
{
    public class PrescriptionProduct : Entity
    {
        public Prescription Prescription { get; set; }
        public Medicine Medicine { get; set; }
        public Decimal Amount { get; set; }
        public String Unit { get; set; }
    }
}
