using System;
using WinConsoleUILibrary.Tools;

namespace WinConsoleUILibrary.ConsoleService
{
    public interface IConsole
    {
        int CursorTop { get; set; }

        int CursorLeft { get; set; }

        void WriteAt(Position pos, Boolean keepCursorPosition, String toWrite);
    }
}
