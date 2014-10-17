namespace ClearMeasure.NumberCruncher
{
    /// <summary>
    /// Defines how a text will be printed.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Prints the text.
        /// </summary>
        /// <param name="text">The text to print.</param>
        void Print(string text);
    }
}