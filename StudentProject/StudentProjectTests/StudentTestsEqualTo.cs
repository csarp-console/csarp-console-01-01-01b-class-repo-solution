namespace StudentProject.Tests
{
    [TestClass()]
    public class StudentTestsEqualTo
    {
        [TestMethod()]
        public void EqualToTestDifferentName()
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
                Age = 17,
            };
            // act
            bool actual = adel.EqualTo(janos);
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestDifferentAge()
        {
            // arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student janos = new Student
            {
                Name = "Kis Adél",
                Age = 18,
            };
            // act
            bool actual = adel.EqualTo(janos);
            // assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void EqualToTestAllPropertyDifferent()
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
            bool actual = adel.EqualTo(janos);
            // assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void EqualToTestAllSameStudent()
        {
            // arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student janos = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            // act
            bool actual = adel.EqualTo(janos);
            // assert
            Assert.IsTrue(actual);
        }
    }
}