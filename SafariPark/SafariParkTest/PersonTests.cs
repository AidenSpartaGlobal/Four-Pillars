namespace SafariParkTest
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        //[TestCase("1", "2", "3")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            //Arrange
            var subject = new Person(fName, lName);
            //Act
            var result = subject.FullName;
            //Assert
            Assert.AreEqual(expected, result);
        }


        //[Test]
        //public void AgeThrowsExceptionTest()
        //{
        //    var subject = new Person("A", "B", 100);
        //    Assert.That(() => subject, Throws.TypeOf<ArgumentException>().With.Message.Contains(" Out of Range"));
        //}


        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }

        [TestCase(99, 99)]
        [TestCase( 0, 0)]
        [TestCase(35, 35)] 
        [TestCase(-1, -1)]
        [TestCase(100, 100)]
        [TestCase(15, 25)]
        [TestCase(15, -1)]

        public void GetAgeTest(int age, int expected)
        {
            var subject = new Person("A", "B", age);
            var result = subject.Age;
            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}