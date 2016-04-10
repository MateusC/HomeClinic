using System;

namespace HomeClinic.Domain.Entity
{
    public class PetKind : Entity
    {
        public virtual String Name { get; set; }
        public virtual String Initials { get; set; }
    }
}
