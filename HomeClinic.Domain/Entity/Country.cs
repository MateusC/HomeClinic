using System;

namespace HomeClinic.Domain.Entity
{
    public class Country : Entity
    {
        public virtual String Name { get; set; }
        public virtual State State { get; set; }
    }
}