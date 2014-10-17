using System;

namespace ClearMeasure.NumberCruncher.PrinterFormatters
{
    [Serializable]
    public class ResultStoreExteption : Exception
    {
        public ResultStoreExteption() { }
        public ResultStoreExteption(string message) : base(message) { }
        public ResultStoreExteption(string message, Exception inner) : base(message, inner) { }
        protected ResultStoreExteption(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
