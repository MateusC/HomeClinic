using System;

namespace HomeClinic.Domain.Entity
{
    public class Country : Entity
    {
        public String Name { get; set; }
        public State State { get; set; }
    }
}