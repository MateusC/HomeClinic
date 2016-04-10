using System;

namespace HomeClinic.Domain.Entity
{
    public class Enterprise : Entity
    {
        public virtual String Name { get; set; }
        public virtual String FancyName { get; set; }
        public virtual String Cnpj { get; set; }
        public virtual String Adress { get; set; }
        public virtual String Neighborhood { get; set; }
        public virtual String PhoneNumberOne { get; set; }
        public virtual String PhoneNumberTwo { get; set; }
        public virtual Country Country { get; set; }
    }
}
