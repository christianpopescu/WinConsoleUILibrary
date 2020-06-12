namespace WinConsoleUILibrary.Controls
{
    public class InputField
    {
        int MaxSize {get; set;}
        string Value {get; set;}
        int CursorPosition {get; set;}

        private InputField()
        {
            CursorPosition = 0;
            Value = "";
        }

        public InputField(int maxSize) : this() => MaxSize = maxSize;

        public void AddChar(char chr) 
        {
            if (CursorPosition < MaxSize + 1) 
            {
                Value += chr;
                CursorPosition++;
            }

        }

    }
}