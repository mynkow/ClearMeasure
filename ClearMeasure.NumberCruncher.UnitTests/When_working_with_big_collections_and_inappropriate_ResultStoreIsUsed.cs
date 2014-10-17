using System;
using System.Linq;
using ClearMeasure.NumberCruncher.PrinterFormatters;
using ClearMeasure.NumberCruncher.Printers;
using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Ignore("Takes a lot of time. Probably should be part of tests executed on CI environment.")]
    [Subject("NumberCruncher.Formatters.ResultStore")]
    public class When_working_with_big_collections_and_inappropriate_ResultStoreIsUsed
    {
        Establish context = () =>
        {
            printer = new UnitTestPrinter();
            cruncher = new Cruncher(new DefaultPrinterFormatter(() => new StringBuilderResultStore()), printer);
        };

        Because of = () => cruncher.Execute(Enumerable.Range(Int32.MinValue / 2, Int32.MaxValue));

        It a__ResultStoreException__should_be_thrown = () => expectedException.ShouldBeOfExactType<ResultStoreExteption>();

        static Exception expectedException;
        static Cruncher cruncher;
        static UnitTestPrinter printer;
    }
}