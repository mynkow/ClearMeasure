using System.Linq;
using ClearMeasure.NumberCruncher.PrinterFormatters;
using ClearMeasure.NumberCruncher.Printers;
using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Subject("NumberCruncher.Formatters.NewLine")]
    public class When_two_numbers_are_crunched
    {
        Establish context = () =>
        {
            printer = new UnitTestPrinter();
            cruncher = new Cruncher(new DefaultPrinterFormatter(() => new StringBuilderResultStore()), printer);
        };

        Because of = () => cruncher.Execute(Enumerable.Range(1, 2));

        It should_return_two_lines_in_the_output_string = () => printer.AllLines.ShouldEqual(expected);

        static string expected = "1\r\n2\r\n";
        static Cruncher cruncher;
        static UnitTestPrinter printer;
    }
}