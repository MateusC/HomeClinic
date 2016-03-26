using System;

namespace HomeClinic.Domain.Entity
{
    public class Breed : Entity
    {
        public String Name { get; set; }
        public AnimalKind Kind { get; set; }
    }
}
