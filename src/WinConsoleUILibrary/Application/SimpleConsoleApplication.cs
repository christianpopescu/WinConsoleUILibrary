using System;
using WinConsoleUILibrary.Controls;

namespace WinConsoleUILibrary.Application
{
    /// <summary>
    /// Simple Console Class
    ///    - contains only one window
    /// </summary>
    public class SimpleConsoleApplication : IApplication
    {
        protected Window theWindow = new Window();
        public void Run()
        {
            theWindow.Run();
        }

        public SimpleConsoleApplication AddControlToWindow(IControl control)
        {
            theWindow.AddControl(control);
            return this;

        }
    }
}
