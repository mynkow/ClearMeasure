using System;
using System.Linq;
using ClearMeasure.NumberCruncher.PrinterFormatters;
using ClearMeasure.NumberCruncher.Printers;
using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Ignore("Takes a lot of time. Probably should be part of tests executed on CI environment.")]
    [Subject("NumberCruncher.Formatters.ResultStore")]
    public class When_working_with_big_collections_and_FileResultStore
    {
        Establish context = () =>
        {
            printer = new UnitTestPrinter();
            cruncher = new Cruncher(new DefaultPrinterFormatter(() => new FileResultStore()), printer);
        };

        Because of = () => cruncher.Execute(Enumerable.Range(Int32.MinValue / 2, Int32.MaxValue));

        It should_return_really_big_string = () => printer.AllLines.Length.ShouldBeGreaterThan(Int32.MaxValue);

        static Cruncher cruncher;
        static UnitTestPrinter printer;
    }
}