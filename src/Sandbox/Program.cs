using WinConsoleUILibrary.Tools;
using WinConsoleUILibrary.Controls;
using WinConsoleUILibrary.Application;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleConsoleApplication sca = new SimpleConsoleApplication();

            sca.AddControlToWindow(new InputField(10, new Position(20, 20)))
                .AddControlToWindow(new InputField(15, new Position(20, 21)));
            sca.Run();
        }
    }
}
