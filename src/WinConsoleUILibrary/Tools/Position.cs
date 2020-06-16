using System;
using System.Collections.Generic;
using System.Text;

namespace WinConsoleUILibrary.Tools
{
    public class Position : Coordinate2D
    {

        public Position():base(0,0) {}
        public Position(int r, int c) : base(r,c) {}

    }
}
