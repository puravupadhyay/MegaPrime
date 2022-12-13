using Megaprime.Services.Interfaces;

namespace Megaprime.Services
{
    ///<inheritdoc />
    public class MegaPrimeService : IMegaPrimeService
    {
        private readonly int[] _singlePrimes = { 2, 3, 5, 7 };

        private readonly INumberService _numberService;

        /// <summary>
        /// Default constructor for the service
        /// </summary>
        /// <param name="numberService"></param>
        public MegaPrimeService(INumberService numberService)
        {
            _numberService = numberService;
        }

        ///<inheritdoc />
        public Task<bool> IsMegaPrime(int primeNumber)
        {
            var numberArray = _numberService.SplitNumber(primeNumber);
            return Task.Run(() => numberArray.All(number => _singlePrimes.Contains(number)));
        }

        ///<inheritdoc />
        public Task<bool> IsPrime(int number)
        {
            return Task.Run(() =>
            {
                var counter = 0;
                for (var i = 2; i <= number / 2; i++)
                {
                    if (number % i != 0) continue;
                    counter++;
                    break;
                }

                return counter == 0 && number > 1;
            });
        }
    }
}
