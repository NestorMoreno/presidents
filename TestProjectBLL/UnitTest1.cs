using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using BLL;

namespace TestProjectBLL
{
    [TestClass]
    public class BBLPresidentTest
    {
        [TestMethod]
        public void calculatePresidentAgeTest()
        {
            PersonalInformation obj = new PersonalInformation();
            double result = obj.getAge(new President() { Country= "US", Birthday = DateTime.Now, DeathDay = DateTime.Now });
            Assert.AreEqual(0, result);
        }
    }
}
