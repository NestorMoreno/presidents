using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    public class PersonalInformation : IPresidentOperations
    {
        public int getAge(President president)
        {
            return (Int16)((president.DeathDay - president.Birthday).Days/365);
        }
    }
}
