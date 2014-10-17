using System;

namespace ClearMeasure.NumberCruncher
{
    /// <summary>
    /// Defines how to display a text to the console.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Prints the text to the console.
        /// </summary>
        /// <param name="text">The text to print.</param>
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}