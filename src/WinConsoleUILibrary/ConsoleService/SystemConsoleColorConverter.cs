using System;

namespace WinConsoleUILibrary.ConsoleService
{
    public class SystemConsoleColorConverter : IColorConverter<System.ConsoleColor>
    {
        public ConsoleColor FromAbstract(AbstractColor color)
        {
            throw new NotImplementedException();
        }

        public AbstractColor ToAbstract(ConsoleColor color)
        {
            switch (color)
            {
                case (ConsoleColor.Black): return AbstractColor.Black;
                
            }

            throw (new ConversionException("No conversion available for color: " + color));
        }
    }
}
