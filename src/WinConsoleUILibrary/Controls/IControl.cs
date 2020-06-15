using System;
namespace WinConsoleUILibrary.Controls
{
    public interface IControl
    {
        public void Draw();
        public void SendKey(ConsoleKeyInfo consoleKeyInfo);
    }
}