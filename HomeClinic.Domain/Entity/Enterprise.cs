using System;

namespace HomeClinic.Domain.Entity
{
    public class Enterprise : Entity
    {
        public String Name { get; set; }
        public String FancyName { get; set; }
        public String Cnpj { get; set; }
        public String Adress { get; set; }
        public String Neighborhood { get; set; }
        public String PhoneNumberOne { get; set; }
        public String PhoneNumberTwo { get; set; }
        public Country Country { get; set; }
    }
}
