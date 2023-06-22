using UserRegistration;

namespace PatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Ritvik";
            ValidatePattern test = new ValidatePattern(expectedResult);

            //Act
            string result = test.ValidFirstName();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}