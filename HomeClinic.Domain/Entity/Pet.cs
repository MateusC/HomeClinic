using System;

namespace HomeClinic.Domain.Entity
{
    public class Pet : Entity
    {
        public virtual String Name { get; set; }
        public virtual DateTime BirthDay { get; set; }
        public virtual Breed PetBreed { get; set; }
        public virtual String ColorOne { get; set; }
        public virtual String ColorTwo { get; set; }
        public virtual String Pelage { get; set; }
        public virtual String Observation { get; set; }
        public virtual DateTime RegisterDate { get; set; }
        public virtual Account Account { get; set; }
    }
}
