using Megaprime.Services.Interfaces;

namespace Megaprime.Services
{
    ///<inheritdoc />
    public class NumberService : INumberService
    {
        ///<inheritdoc />
        public int[] SplitNumber(int number)
        {
            return number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
        }
        ///<inheritdoc />
        public bool IsDoubleDigit(int number)
        {
            return number > 9;
        }
    }
}
