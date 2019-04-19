using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPE4._2_GSB_CE;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {

  
        [TestMethod]
        public void GetAgeFromBirth()
        {
            Employee emp = new Employee();

        var anniv =    emp.BirthDate = DateTime.Parse("22/10/1996");

            var age = emp.GetAgeFromBirth;

            if (anniv> DateTime.Today.AddYears(-age))
            {
                age--;
            }

            Assert.AreEqual(22, age,"erreur dans l'age");

        }

        [TestMethod]
        public void GetFullName()
        {
            Employee emp = new Employee();
            emp.FirstName = "Rogal";
            emp.LastName = "Dorn";


            Assert.AreEqual("Rogal Dorn",emp.ToString(),"erreur dans le fullname");

        }



    }
}
