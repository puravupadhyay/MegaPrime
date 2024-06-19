using Megaprime.Services;
using Megaprime.Services.Interfaces;
using NUnit.Framework;

namespace Megaprime.Tests.Services
{
// Test service
    [TestFixture]
    public class MegaPrimeServiceTests
    {
        private IMegaPrimeService _sut;
        private INumberService _numberService;

        [SetUp]
        public void SetUp()
        {
            _numberService = new NumberService();
            _sut = new MegaPrimeService(_numberService);
        }

        [Test]
        public async Task IsMegaPrime_ReturnsTrue()
        {
            // Arrange
            var primeNumber = 77;

            // Act
            var result = await _sut.IsMegaPrime(primeNumber);

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public async Task IsMegaPrime_ReturnsFalse()
        {
            // Arrange
            var primeNumber = 80;

            // Act
            var result = await _sut.IsMegaPrime(primeNumber);

            // Assert
            Assert.False(result);
        }

        [Test]
        public async Task IsPrime_ReturnsTrue()
        {
            // Arrange
            var primeNumber = 37;

            // Act
            var result = await _sut.IsPrime(primeNumber);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsPrime_ReturnsFalse()
        {
            // Arrange
            var primeNumber = 93;

            // Act
            var result = await _sut.IsPrime(primeNumber);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
