using Megaprime.Services;
using Megaprime.Services.Interfaces;
using NUnit.Framework;

namespace Megaprime.Tests.Services
{
    [TestFixture]
    public class PrintServiceTests
    {
        private IPrintService _sut;
        private IMegaPrimeService _megaPrimeService;
        private INumberService _numberService;

        [SetUp]
        public void SetUp()
        {
            _numberService = new NumberService();
            _megaPrimeService = new MegaPrimeService(_numberService);
            _sut = new PrintService(_megaPrimeService);
        }

        [Test]
        public async Task GenerateNumbers_ReturnsList()
        {
            // Arrange
            var start = 0;
            var end = 37;
            var expectedResult = new List<int> { 2, 3, 5, 7, 23, 37 };

            // Act
            var result = await _sut.GenerateNumbers(start, end);

            // Assert

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.AreEqual(result,expectedResult);
            Assert.IsInstanceOf(typeof(List<int>), result);
        }
    }
}
