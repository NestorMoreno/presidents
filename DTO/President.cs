using System;

namespace DTO
{
    
    public class President: EntityBase
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DeathDay { get; set; }
        public string DeathPlace { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
    }
}
