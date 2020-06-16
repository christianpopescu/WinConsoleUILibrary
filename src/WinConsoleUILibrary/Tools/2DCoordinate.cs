namespace WinConsoleUILibrary.Tools
{
    public class Coordinate2D
    {

        public Coordinate2D():this(0,0) {}
        public Coordinate2D(int r, int c)
        { 
            Raw = r;
            Column = c;
        }
        public int Raw {get; set;}
        public int Column {get; set;}
    }
}