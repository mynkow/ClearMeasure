using System.Text;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Adds " fizz" if the number is divided by 3.
    /// Adds " buzz" when the number is divided by 5.
    /// </summary>
    public class FizzBuzz : INumberFormatter
    {
        public const string Fizz = " fizz";
        public const string Buzz = " buzz";

        /// <summary>
        /// Formats the specified number.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <returns>Returns formatted string of a number.</returns>
        public string Format(int number)
        {
            StringBuilder result = new StringBuilder();

            if (number % 3 == 0) result.Append(Fizz);
            if (number % 5 == 0) result.Append(Buzz);

            return result.ToString();
        }
    }
}