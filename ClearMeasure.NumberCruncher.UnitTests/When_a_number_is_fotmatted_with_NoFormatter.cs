using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Subject("NumberCruncher.Formatters.NoFormatter")]
    public class When_a_number_is_fotmatted_with_NoFormatter
    {
        Establish context = () => formatter = new NoFormatter();

        Because of = () => actual = formatter.Format(-12);

        It should_return_the_input_number_as_a_string = () => actual.ShouldEqual(expected);

        static string actual;
        static string expected = "-12";

        static NoFormatter formatter;
    }
}