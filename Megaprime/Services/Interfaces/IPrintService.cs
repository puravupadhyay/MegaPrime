namespace Megaprime.Services.Interfaces
{
    /// <summary>
    /// Service for printing number
    /// </summary>
    public interface IPrintService
    {
        /// <summary>
        /// Method to print mega prime numbers for the given range
        /// </summary>
        /// <param name="startNumber"></param>
        /// <param name="endNumber"></param>
        /// <returns></returns>
        Task PrintNumbersAsync(int startNumber, int endNumber);

        /// <summary>
        /// Generates a list of mega prime integers for the given range
        /// </summary>
        /// <param name="startNumber"></param>
        /// <param name="endNumber"></param>
        /// <returns></returns>
        Task<List<int>> GenerateNumbers(int startNumber, int endNumber);
    }
}
