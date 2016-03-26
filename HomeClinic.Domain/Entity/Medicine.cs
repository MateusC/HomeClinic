using System;

namespace HomeClinic.Domain.Entity
{
    public class Medicine : Entity
    {
        public String Name { get; set; }
        public String TechnicalName { get; set; }
        public String Application { get; set; }
        public String Observation { get; set; }
    }
}