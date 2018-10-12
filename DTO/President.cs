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
        //public string ContractTypeName { get; set; }
        //public int RoleId { get; set; }
        //public string RoleName { get; set; }
        //public string RoleDescription { get; set; }
        //public double HourlySalary { get; set; }
        //public double MonthlySalary { get; set; }
        //public double Salary { get; set; }
    }
}
