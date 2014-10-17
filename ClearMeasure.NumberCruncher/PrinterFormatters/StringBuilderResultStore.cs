using System.Text;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Stores the formatted text in a <see cref="StringBuilder"/>
    /// </summary>
    /// <remarks>Use this to store the formatted resilt of small sequences of numbers. For large sequences consider
    /// using <see cref="FileResultStore"/> or you can implement you own by inhriting the <see cref="IFormattedResultStore"/> interface</remarks>
    public class StringBuilderResultStore : IFormattedResultStore
    {
        StringBuilder store = new StringBuilder();

        /// <summary>
        /// Appends a text to the current formatted text.
        /// </summary>
        /// <param name="text">The text to append.</param>
        public void Append(string text)
        {
            store.Append(text);
        }

        /// <summary>
        /// Gets the formatted text.
        /// </summary>
        /// <returns>Returns the formatted text.</returns>
        public string GetResult()
        {
            return store.ToString();
        }
    }
}