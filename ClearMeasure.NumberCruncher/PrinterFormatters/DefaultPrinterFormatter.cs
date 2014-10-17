using System;
using System.Collections.Generic;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    /// <summary>
    /// Default printer formatter.
    /// </summary>
    /// <remarks>Automatically adds <see cref="NoFormatter"/> as a first formatter and <see cref="NewLine" as a last formatter./></remarks>
    public sealed class DefaultPrinterFormatter : IPrinterFormatter
    {
        private readonly List<INumberFormatter> numberFormatters;
        private readonly Func<IFormattedResultStore> resultStoreFactory;

        /// <summary>
        /// Creates a new instance of the default formatter.
        /// </summary>
        /// <param name="numberFormatters">Additional formatters which are applied to every number. The order matters.</param>
        public DefaultPrinterFormatter(Func<IFormattedResultStore> resultStoreFactory, params INumberFormatter[] numberFormatters)
        {
            this.resultStoreFactory = resultStoreFactory;

            this.numberFormatters = new List<INumberFormatter>();
            this.numberFormatters.Add(new NoFormatter());
            this.numberFormatters.AddRange(numberFormatters);
            this.numberFormatters.Add(new NewLine());
        }

        /// <summary>
        /// Creates a friendly output for a given sequence of numbers.
        /// </summary>
        /// <param name="numbers">The numbers to format.</param>
        /// <returns>Returns a formatted string.</returns>
        public string Format(IEnumerable<int> numbers)
        {
            try
            {
                var resultStore = resultStoreFactory();
                foreach (var number in numbers)
                {
                    numberFormatters.ForEach(f => resultStore.Append(f.Format(number)));
                }

                return resultStore.GetResult();
            }
            catch (OutOfMemoryException ex)
            {
                throw new ResultStoreExteption("Fatal error. Consider another implementation of IFormattedResultStore", ex);
            }
        }
    }
}