using System;

namespace HomeClinic.Domain.Entity
{
    public class User : Entity
    {
        public virtual String Name { get; set; }
        public virtual String Password { get; set; }
    }
}
