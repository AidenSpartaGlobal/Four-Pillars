namespace SafariParkTest
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            //Arrange
            var subject = new Person(fName, lName);
            //Act
            var result = subject.FullName;
            //Assert
            Assert.AreEqual(expected, result);
        }




        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
}