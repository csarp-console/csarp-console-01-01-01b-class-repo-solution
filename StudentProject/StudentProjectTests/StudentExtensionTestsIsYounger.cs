using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Tests
{
    [TestClass()]
    public class StudentExtensionTestsIsYounger
    {
        [TestMethod()]
        public void IsYoungerTestFirsIsYounger()
        {
            // arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student janos = new Student
            {
                Name = "Kis János",
                Age = 18,
            };
            // act
            bool actual=adel.IsYounger(janos);
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsYoungerTestSecondIsYounger()
        {
            // arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student janos = new Student
            {
                Name = "Kis János",
                Age = 15,
            };
            // act
            bool actual = adel.IsYounger(janos);
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsYoungerTestSameAge()
        {
            // arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 18,
            };
            Student janos = new Student
            {
                Name = "Kis János",
                Age = 18,
            };
            // act
            bool actual = adel.IsYounger(janos);
            // assert
            Assert.IsFalse(actual);
        }
    }
}