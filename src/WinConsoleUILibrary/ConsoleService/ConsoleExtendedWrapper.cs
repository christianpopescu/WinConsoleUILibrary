using System;
using System.Collections.Generic;
using System.Text;
using WinConsoleUILibrary.Tools;

namespace WinConsoleUILibrary.ConsoleService
{
    /// <summary>
    ///  Implements extension of Console class that implements IConsole interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TC"></typeparam>
    public class ConsoleExtendedWrapper<T,TC>:IConsoleExtensions where T : IConsole<TC> where TC : System.Enum
    {
        private IConsole<TC> _console;

        private IColorConverter<TC> _colorConverter;

        private ConsoleExtendedWrapper()
        {}
        public ConsoleExtendedWrapper(T console, IColorConverter<TC> colorConverter)
        {
            _console = console;
            _colorConverter = colorConverter;
        }

        public IConsole<TC> console
        {
            get => _console;
        }
        public void WriteAt(Position pos, bool keepCursorPosition, string toWrite)
        {
            Position save = null;
            if (keepCursorPosition)
            {
                save = new Position(_console.CursorTop, _console.CursorLeft);
            }
            _console.SetCursorPosition(pos.Raw, pos.Column);
            _console.WriteLine(toWrite);
            if (keepCursorPosition)
            {
                _console.SetCursorPosition(save.Column, save.Raw);
            }

        }

        public void WriteAtWithColors(Position pos, AbstractColor backgroundColor, AbstractColor foregroundColor, bool keepCursorPosition,
            bool keepColors, string toWrite)
        {
            // Save
            Position save = null;
            if (keepCursorPosition)
            {
                save = new Position(_console.CursorTop, _console.CursorLeft);
            }


            AbstractColor bckpBackgroundColor = _colorConverter.ToAbstract(_console.BackgroundColor);
            AbstractColor bckpForegroundColor = _colorConverter.ToAbstract(_console.ForegroundColor);

        // Set
            _console.SetCursorPosition(pos.Raw, pos.Column);
            _console.BackgroundColor = _colorConverter.FromAbstract(backgroundColor);
            _console.ForegroundColor = _colorConverter.FromAbstract(foregroundColor);
            
            // Do job
            _console.WriteLine(toWrite);

            // Restore if necessary
            if (keepCursorPosition)
            {
                _console.SetCursorPosition(save.Column, save.Raw);
            }

            if (keepColors)
            {
                _console.BackgroundColor = _colorConverter.FromAbstract(bckpBackgroundColor);
                _console.ForegroundColor = _colorConverter.FromAbstract(bckpForegroundColor);
            }
        }
    }
}
