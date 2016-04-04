using System;

namespace HomeClinic.Domain.Entity
{
    public class Pet : Entity
    {
        public String Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Breed PetBreed { get; set; }
        public String ColorOne { get; set; }
        public String ColorTwo { get; set; }
        public String Pelage { get; set; }
        public String Observation { get; set; }
        public DateTime RegisterDate { get; set; }
        public Account Account { get; set; }
    }
}
