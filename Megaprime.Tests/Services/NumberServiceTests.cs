using Megaprime.Services;
using Megaprime.Services.Interfaces;
using NUnit.Framework;

namespace Megaprime.Tests.Services
{
    [TestFixture]
    public class NumberServiceTests
    {
        private INumberService _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new NumberService();
        }

        [Test]
        public void SplitNumber_ReturnsIntArray()
        {
            // Arrange
            var number = 45467;

            // Act
            var result = _sut.SplitNumber(number);

            // Assert
            Assert.AreEqual(result[0], 4);
            Assert.AreEqual(result[1], 5);
            Assert.AreEqual(result[2], 4);
            Assert.AreEqual(result[3], 6);
            Assert.AreEqual(result[4], 7);

            Assert.AreEqual(result.Length,5);
            Assert.IsInstanceOf(typeof(int[]), result);
        }

        [Test]
        public void IsDoubleDigit_ReturnsTrue()
        {
            // Arrange
            var number = 19;

            // Act
            var result = _sut.IsDoubleDigit(number);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsDoubleDigit_ReturnsFalse()
        {
            // Arrange
            var number = 5;

            // Act
            var result = _sut.IsDoubleDigit(number);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
