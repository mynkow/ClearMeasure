using System.Collections.Generic;

namespace ClearMeasure.NumberCruncher
{
    /// <summary>
    /// Defines how to format a sequence of numbers.
    /// </summary>
    public interface IPrinterFormatter
    {
        /// <summary>
        /// Creates a friendly output for a given sequence of numbers.
        /// </summary>
        /// <param name="numbers">The numbers to format.</param>
        /// <returns>Returns a formatted string.</returns>
        string Format(IEnumerable<int> numbers);
    }
}