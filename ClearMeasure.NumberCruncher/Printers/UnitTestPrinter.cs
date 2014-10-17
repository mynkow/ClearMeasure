using System.Collections.Generic;

namespace ClearMeasure.NumberCruncher.Printers
{
    /// <summary>
    /// Use this only for unit tests. 
    /// </summary>
    public class UnitTestPrinter : IPrinter
    {
        public string AllLines { get; set; }

        /// <summary>
        /// Adds the text to the <see cref="AllLines"/>
        /// </summary>
        /// <param name="text">The text to print.</param>
        public void Print(string text)
        {
            AllLines = text;
        }
    }
}