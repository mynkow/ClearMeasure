﻿using ClearMeasure.NumberCruncher.PrinterFormatters;
using Machine.Specifications;

namespace ClearMeasure.NumberCruncher.UnitTests
{
    [Subject("NumberCruncher.Formatters.FizzBuzzFormatter")]
    public class When_a_number_devides_by_3_and_FizzBuzzFormatter_is_applied
    {
        Establish context = () => formatter = new FizzBuzz();

        Because of = () => actual = formatter.Format(-3);

        It should_return_Fizz_in_the_output_string = () => actual.ShouldEqual(expected);

        static string actual;
        static string expected = " fizz";

        static FizzBuzz formatter;
    }
}