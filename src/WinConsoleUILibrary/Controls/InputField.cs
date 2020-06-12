using System.Collections.Generic;

namespace WinConsoleUILibrary.Controls
{
    public class InputField
    {
        private List<char> _value;
        public int MaxSize {get; set;}
        public string Value
        {
            get => new string(_value.ToArray());
        }
        public int CursorPosition {get; set;}

        private InputField()
        {
            CursorPosition = 0;
        }

        public InputField(int maxSize) : this() => MaxSize = maxSize;

        public void AddChar(char chr) 
        {
            if (CursorPosition < MaxSize + 1) 
            {
                _value.Add(chr);
                CursorPosition++;
            }
        }

        public void DeleteLeft()
        {
            if (CursorPosition > 0)
            {

            }
        }

    }
}