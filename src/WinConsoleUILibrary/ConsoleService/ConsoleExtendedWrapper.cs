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
    public class ConsoleExtendedWrapper<T>:IConsoleExtensions where T : IConsole
    {
        private readonly IConsole _console;

        private ConsoleExtendedWrapper()
        {}
        public ConsoleExtendedWrapper(T console)
        {
            _console = console;
        }

        public IConsole console
        {
            get => _console;
        }
        public void WriteAt(Position pos, bool keepCursorPosition, string toWrite)
        {
            Position save = new Position(0, 0);
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
    }
}
