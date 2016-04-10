using System;

namespace HomeClinic.Domain.Entity
{
    public class Medicine : Entity
    {
        public virtual String Name { get; set; }
        public virtual String TechnicalName { get; set; }
        public virtual String Application { get; set; }
        public virtual String Observation { get; set; }
    }
}