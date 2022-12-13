using Megaprime.Services.Interfaces;

namespace Megaprime.Services
{
    ///<inheritdoc />
    public class PrintService : IPrintService
    {
        private readonly IMegaPrimeService _megaPrimeService;

        /// <summary>
        /// Default constructor for the service
        /// </summary>
        public PrintService(IMegaPrimeService megaPrimeService)
        {
            _megaPrimeService = megaPrimeService;
        }

        ///<inheritdoc />
        public async Task PrintNumbersAsync(int startNumber, int endNumber)
        {
            var megaPrimes = await GenerateNumbers(startNumber, endNumber);
            var result = $"[{string.Join(",", megaPrimes.ToArray())}]";
            Console.WriteLine(result);
        }

        ///<inheritdoc />
        public async Task<List<int>> GenerateNumbers(int startNumber, int endNumber)
        {
            var result = new List<int>();

            for (var num = startNumber; num <= endNumber; num++)
            {
                if (num > 9)
                {
                    if (await _megaPrimeService.IsMegaPrime(num))
                    {
                        if (await _megaPrimeService.IsPrime(num))
                            result.Add(num);
                    }
                }
                else
                {
                    if (await _megaPrimeService.IsPrime(num))
                        result.Add(num);
                }
            }

            return result;
        }
    }
}
