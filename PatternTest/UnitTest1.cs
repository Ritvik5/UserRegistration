using UserRegistration;

namespace PatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenName_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "Ritvik";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidFirstName();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenLastName_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "Sharma";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidLastName();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void GivenEmail_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "abc.xyz@bl.co.in";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidEmail();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenNumber_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "91 8456584565";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidMobileNumber();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "Qwertyui";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidPassword();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}