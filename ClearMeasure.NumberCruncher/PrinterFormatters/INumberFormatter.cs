namespace ClearMeasure.NumberCruncher
{
    /// <summary>
    /// Defines an action to format a number.
    /// </summary>
    public interface INumberFormatter
    {
        /// <summary>
        /// Formats the specified number.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <returns>Returns formatted string of a number.</returns>
        string Format(int number);
    }
}