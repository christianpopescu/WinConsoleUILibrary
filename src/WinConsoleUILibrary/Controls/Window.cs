using WinConsoleUILibrary.Tools;
using DSALibrary.Collections;
using System;

namespace WinConsoleUILibrary.Controls
{
    public class Window
    {
        public Position TopLeft;

        public CSize Size;

        protected readonly CircularLinkedList<IControl> controls = new CircularLinkedList<IControl>();

        public Window()
        {
            // ToDo: Add constants parameters
            TopLeft = new Position(0, 0);
            Size = new CSize(20, 80);
        }

        public Window AddControl(IControl control)
        {
            controls.AddLast(control);
            return this;
        }

        public void Run()
        {
            ConsoleKeyInfo cki;
            var ci = controls.GetCircularIterator();
            while ((cki = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                char c = cki.KeyChar;
                if (cki.Key == ConsoleKey.Tab)
                {
                    ci.MoveNext();
                }
                else
                    ci.Current().SendKey(cki);
            }
        }
    }
}