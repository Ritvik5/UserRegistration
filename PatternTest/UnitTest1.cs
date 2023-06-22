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
    }
}