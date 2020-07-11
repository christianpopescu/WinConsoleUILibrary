using System;

namespace WinConsoleUILibrary.ConsoleService
{
    public class SystemConsoleColorConverter : IColorConverter<System.ConsoleColor>
    {
        public ConsoleColor FromAbstract(AbstractColor color)
        {
            switch (color)
            {
                case (AbstractColor.Black): return ConsoleColor.Black;
                case (AbstractColor.Blue): return ConsoleColor.Blue;
                case (AbstractColor.Cyan): return ConsoleColor.Cyan;
                case (AbstractColor.DarkBlue): return ConsoleColor.DarkBlue;
                case (AbstractColor.DarkCyan): return ConsoleColor.DarkCyan;
                case (AbstractColor.DarkGray): return ConsoleColor.DarkGray;
                case (AbstractColor.DarkGreen): return ConsoleColor.DarkGreen;
                case (AbstractColor.DarkMagenta): return ConsoleColor.DarkMagenta;
                case (AbstractColor.DarkRed): return ConsoleColor.DarkRed;
                case (AbstractColor.DarkYellow): return ConsoleColor.DarkYellow;
                case (AbstractColor.Gray): return ConsoleColor.Gray;
                case (AbstractColor.Green): return ConsoleColor.Green;
                case (AbstractColor.Magenta): return ConsoleColor.Magenta;
                case (AbstractColor.Red): return ConsoleColor.Red;
                case (AbstractColor.Yellow): return ConsoleColor.Yellow;
                case (AbstractColor.White): return ConsoleColor.White;
            }

            throw (new ConversionException("No conversion available for color: " + color));
        }

        public AbstractColor ToAbstract(ConsoleColor color)
        {
            switch (color)
            {
                case (ConsoleColor.Black): return AbstractColor.Black;
                case (ConsoleColor.Blue): return AbstractColor.Blue;
                case (ConsoleColor.Cyan): return AbstractColor.Cyan;
                case (ConsoleColor.DarkBlue): return AbstractColor.DarkBlue;
                case (ConsoleColor.DarkCyan): return AbstractColor.DarkCyan;
                case (ConsoleColor.DarkGray): return AbstractColor.DarkGray;
                case (ConsoleColor.DarkGreen): return AbstractColor.DarkGreen;
                case (ConsoleColor.DarkMagenta): return AbstractColor.DarkMagenta;
                case (ConsoleColor.DarkRed): return AbstractColor.DarkRed;
                case (ConsoleColor.DarkYellow): return AbstractColor.DarkYellow;
                case (ConsoleColor.Gray): return AbstractColor.Gray;
                case (ConsoleColor.Green): return AbstractColor.Green;
                case (ConsoleColor.Magenta): return AbstractColor.Magenta;
                case (ConsoleColor.Red): return AbstractColor.Red;
                case (ConsoleColor.Yellow): return AbstractColor.Yellow;
                case (ConsoleColor.White): return AbstractColor.White;
            }

            throw (new ConversionException("No conversion available for color: " + color));
        }
    }
}
