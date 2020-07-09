using System;
using WinConsoleUILibrary.Tools;

namespace WinConsoleUILibrary.ConsoleService
{
    /// <summary>
    /// The purpose of this interface is to add methods that are not directly implemented by System Console.
    /// As SystemConsole is a static class we can't use extension method to extend it. The extension will
    /// be implemented in the wrapper class that implements that interface.
    /// </summary>
    public interface IConsoleExtensions
    {
        void WriteAt(Position pos, Boolean keepCursorPosition, String toWrite);

        void WriteAt(Position pos, AbstractColor backgroundColor, AbstractColor foregroundColor,
            Boolean keepCursorPosition, Boolean keepColors, String toWrite);
    }
}
