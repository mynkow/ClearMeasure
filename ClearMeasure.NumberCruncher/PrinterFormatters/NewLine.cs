namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    public class NewLine : INumberFormatter
    {
        public string Format(int number)
        {
            return "\r\n";
        }
    }
}