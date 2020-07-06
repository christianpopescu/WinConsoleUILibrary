﻿using System;
using WinConsoleUILibrary.Tools;

namespace WinConsoleUILibrary.ConsoleService
{
    public class SystemConsoleWrapper:IConsole
    {

        private static readonly SystemConsoleWrapper _instance = new SystemConsoleWrapper();

        private SystemConsoleWrapper() {}

        public static SystemConsoleWrapper Instance
        {
            get => _instance;
        }
        public int CursorTop
        { 
            get => System.Console.CursorTop;
            set => System.Console.CursorTop = value;
        }

        public int CursorLeft
        {
            get => System.Console.CursorLeft; 
            set => System.Console.CursorLeft = value;
        }

        public void SetCursorPosition(int left, int top) => System.Console.SetCursorPosition(left, top);

        #region WriteLine

        public void WriteLine(string text) => System.Console.WriteLine(text);

        #endregion
    }
}
