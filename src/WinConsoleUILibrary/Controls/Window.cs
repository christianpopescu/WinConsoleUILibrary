using WinConsoleUILibrary.Tools;
using DSALibrary.Collections;

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

        // ToDo: Add method to add controls
    }
}