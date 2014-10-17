using System;
using System.Collections.Generic;

namespace ClearMeasure.NumberCruncher
{
    /// <summary>
    /// 
    /// </summary>
    public class Cruncher
    {
        private readonly IPrinterFormatter formatter;
        private readonly IPrinter printer;

        public Cruncher(IPrinterFormatter formatter, IPrinter printer)
        {
            if (ReferenceEquals(null, formatter)) throw new ArgumentNullException("formatter");
            if (ReferenceEquals(null, printer)) throw new ArgumentNullException("printer");

            this.formatter = formatter;
            this.printer = printer;
        }

        public void Execute(IEnumerable<int> numbers)
        {
            var formattedNumbers = formatter.Format(numbers);
            printer.Print(formattedNumbers);
        }
    }
}