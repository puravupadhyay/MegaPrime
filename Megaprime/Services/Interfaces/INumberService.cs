namespace Megaprime.Services.Interfaces
{
    /// <summary>
    /// Service for some general numbers related tasks
    /// </summary>
    public interface INumberService
    {
        /// <summary>
        /// Returns an array full of numbers for a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int[] SplitNumber(int number);

        /// <summary>
        /// Checks if the number is a double digit
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        bool IsDoubleDigit(int number);
    }
}
