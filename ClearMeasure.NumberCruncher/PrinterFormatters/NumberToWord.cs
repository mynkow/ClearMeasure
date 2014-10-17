using Humanizer;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Converts numbers into words.
    /// </summary>
    public class NumberToWord : INumberFormatter
    {
        public string Format(int number)
        {
            return " " + number.ToWords();
        }
    }
}
