using HomeClinic.Domain.Enum;
using System;

namespace HomeClinic.Domain.Entity
{
    public class Account : Entity
    {
        public String Name { get; set; }
        public String FancyName { get; set; }
        public String Cnpj { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public String Adress { get; set; }
        public String Neighborhood { get; set; }
        public Country Country { get; set; }
        public DateTime RegisterDate { get; set; }
        public String PhoneNumberOne { get; set; }
        public String PhoneNumberTwo { get; set; }
        public String Observation { get; set; }
        public AccountKindEnum AccountKind { get; set; }
        public String Crmv { get; set; }

    }
}