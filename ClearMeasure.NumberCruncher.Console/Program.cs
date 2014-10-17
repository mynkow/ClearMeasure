using System;
using System.Collections.Generic;
using ClearMeasure.NumberCruncher;
using ClearMeasure.NumberCruncher.PrinterFormatters;

namespace TheTesst
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new DefaultPrinterFormatter(() => new FileResultStore(), new NumberToWord(), new FizzBuzz());
            var printer = new ConsolePrinter();
            var cruncher = new Cruncher(formatter, printer);

            var data = new List<int>() { 2, 3, 15, 7, 30, 104, 35465 };

            cruncher.Execute(data);

            Console.ReadLine();
        }
    }
}