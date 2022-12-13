namespace Megaprime.Services.Interfaces
{
    /// <summary>
    /// Service for checking if the number is prime or megaprime
    /// </summary>
    public interface IMegaPrimeService
    {
        /// <summary>
        /// Checks if the number is a mega prime
        /// </summary>
        /// <param name="primeNumber"></param>
        /// <returns></returns>
        Task<bool> IsMegaPrime(int primeNumber);

        /// <summary>
        /// Checks if the number is a prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<bool> IsPrime(int number);
    }
}
