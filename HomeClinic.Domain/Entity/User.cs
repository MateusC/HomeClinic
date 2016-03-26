using System;

namespace HomeClinic.Domain.Entity
{
    public class User : Entity
    {
        public String Name { get; set; }
        public String Password { get; set; }
    }
}
