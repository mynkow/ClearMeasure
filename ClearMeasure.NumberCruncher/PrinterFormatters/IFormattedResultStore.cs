namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Defines how formatted text will be stored.
    /// </summary>
    public interface IFormattedResultStore
    {
        /// <summary>
        /// Appends a text to the current formatted text.
        /// </summary>
        /// <param name="text">The text to append.</param>
        void Append(string text);

        /// <summary>
        /// Gets the formatted text.
        /// </summary>
        /// <returns>Returns the formatted text.</returns>
        string GetResult();
    }
}