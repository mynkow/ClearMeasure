using System;
using System.IO;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Stores the formatted text in a <see cref="File"/>
    /// </summary>
    /// <remarks>Use this to store the formatted resilt of large sequences of numbers. For small sequences consider
    /// using <see cref="StringBuilderResultStore"/> or you can implement you own by inhriting the <see cref="IFormattedResultStore"/> interface</remarks>
    public sealed class FileResultStore : IFormattedResultStore
    {
        private readonly string fileName;

        public FileResultStore()
        {
            fileName = DateTime.UtcNow.ToFileTimeUtc().ToString();
        }

        /// <summary>
        /// Appends a text to the current formatted text.
        /// </summary>
        /// <param name="text">The text to append.</param>
        public void Append(string text)
        {
            File.AppendAllText(fileName, text);
        }

        /// <summary>
        /// Gets the formatted text.
        /// </summary>
        /// <returns>Returns the formatted text.</returns>
        public string GetResult()
        {
            return File.ReadAllText(fileName);
        }
    }
}