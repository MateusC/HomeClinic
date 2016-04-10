using HomeClinic.Domain.Enum;
using System;

namespace HomeClinic.Domain.Entity
{
    public class Account : Entity
    {
        public virtual String Name { get; set; }
        public virtual String FancyName { get; set; }
        public virtual String Cnpj { get; set; }
        public virtual String Cpf { get; set; }
        public virtual String Rg { get; set; }
        public virtual String Adress { get; set; }
        public virtual String Neighborhood { get; set; }
        public virtual Country Country { get; set; }
        public virtual DateTime RegisterDate { get; set; }
        public virtual String PhoneNumberOne { get; set; }
        public virtual String PhoneNumberTwo { get; set; }
        public virtual String Observation { get; set; }
        public virtual AccountKindEnum AccountKind { get; set; }
        public virtual String Crmv { get; set; }

    }
}