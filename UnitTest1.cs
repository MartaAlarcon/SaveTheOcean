using vet; 
namespace vetTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Option_ValidOption_ReturnsTrue()
        {
            // Arrange
            int validOption = 1;

            // Act
            bool result = Program.Option(validOption);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Option_InvalidOption_ReturnsFalse()
        {
            // Arrange
            int invalidOption = 3;

            // Act
            bool result = Program.Option(invalidOption);

            // Assert
            Assert.IsFalse(result);
        }
    }
}