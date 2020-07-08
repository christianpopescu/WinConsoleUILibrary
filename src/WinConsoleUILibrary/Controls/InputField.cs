using System;
using System.Collections.Generic;
using WinConsoleUILibrary.Tools;
using WinConsoleUILibrary.ConsoleService;

namespace WinConsoleUILibrary.Controls
{
    public class InputField<T,TC> : IControl where T : IConsole<TC> where TC : System.Enum
    {
        private List<char> _value = new List<char>();

        private ConsoleExtendedWrapper<T,TC> _consoleExtendedWrapper;

        public int MaxSize {get; set;}
        public string Value
        {
            get => new string(_value.ToArray());
        }
        public int CursorPosition {get; set;}

        public Position ScreenPosition {get; set;}

        private InputField()
        {
            CursorPosition = 0;
        }

        private InputField(int maxSize) : this() => MaxSize = maxSize;

        private InputField(int maxSize, Position screenPosition) : this(maxSize) => ScreenPosition = screenPosition;

        public InputField(int maxSize, Position screenPosition, ConsoleExtendedWrapper<T,TC> consoleExtendedWrapper)
            : this(maxSize, screenPosition) => _consoleExtendedWrapper = consoleExtendedWrapper;
  
        public void AddChar(char chr) 
        {
            if (CursorPosition < MaxSize ) 
            {
                _value.Add(chr);
                CursorPosition++;
            }
        }

        public void DeleteLeft()
        {
            if (CursorPosition > 0)
            {
                _value.RemoveAt(CursorPosition-1);
                CursorPosition--;
            }
        }

        protected void ClearFieldOnScreen()
        {
            _consoleExtendedWrapper.WriteAt(ScreenPosition, true, new String(' ', MaxSize));
        }
        public void Draw()
        {
            ClearFieldOnScreen();
            _consoleExtendedWrapper.WriteAt(ScreenPosition, true, Value);
        }

        public void SendKey(ConsoleKeyInfo consoleKeyInfo)
        {
                char c = consoleKeyInfo.KeyChar;
                if (c != '\0' && c != '\b' && c != '\t')
                {
                    AddChar(c);
                    Draw();
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace)
                {
                    DeleteLeft();
                    Draw();
                }
        }
          
    }
}