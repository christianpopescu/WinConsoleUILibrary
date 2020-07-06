using System;


namespace WinConsoleUILibrary.ConsoleService
{
    public interface IConsole
    {
        int CursorTop { get; set; }

        int CursorLeft { get; set; }

        void SetCursorPosition(int left, int top);

        #region WriteLine

        void WriteLine(String text);

        #endregion


    }
}
