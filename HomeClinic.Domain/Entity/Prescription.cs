using System;

namespace HomeClinic.Domain.Entity
{
    public class Prescription : Entity
    {
        public Account Account { get; set; }
        public Animal Animal { get; set; }
        public DateTime Date { get; set; }
    }
}
