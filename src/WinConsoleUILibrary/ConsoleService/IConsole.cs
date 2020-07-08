using System;


namespace WinConsoleUILibrary.ConsoleService
{
    public interface IConsole<TC>  where TC : System.Enum
    {
        int CursorTop { get; set; }

        int CursorLeft { get; set; }

        void SetCursorPosition(int left, int top);

        TC BackgroundColor { get; set; }

        TC ForegroundColor { get; set; }

        #region WriteLine

        void WriteLine(String text);

        #endregion


    }
}
