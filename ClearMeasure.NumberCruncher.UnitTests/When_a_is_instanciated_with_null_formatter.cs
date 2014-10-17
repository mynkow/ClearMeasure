using System;
using ClearMeasure.NumberCruncher.Printers;
using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Subject("NumberCruncher.Cruncher")]
    public class When_a_is_instanciated_with_null_formatter
    {
        Because of = () => expectedException = Catch.Exception(() => new Cruncher(null, new UnitTestPrinter()));

        It an__ArgumentNullException__should_be_thrown = () => expectedException.ShouldBeOfExactType<ArgumentNullException>();

        static Exception expectedException;
    }
}