namespace ClearMeasure.NumberCruncher
{
    public class NoFormatter : INumberFormatter
    {
        public string Format(int number)
        {
            return number.ToString();
        }
    }
}