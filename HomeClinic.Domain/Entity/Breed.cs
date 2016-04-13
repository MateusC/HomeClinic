using System;

namespace HomeClinic.Domain.Entity
{
    public class Breed : Entity
    {
        public virtual String Name { get; set; }
        public virtual PetKind Kind { get; set; }
    }
}
