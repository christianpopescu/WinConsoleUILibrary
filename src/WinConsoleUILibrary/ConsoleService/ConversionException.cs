using System;


namespace WinConsoleUILibrary.ConsoleService
{
    public class ConversionException : Exception
    {
        public ConversionException() {}

        public ConversionException(string message) : base (message) { }

        public ConversionException(string message, Exception innerException) : base(message, innerException ) { }
    }
}
