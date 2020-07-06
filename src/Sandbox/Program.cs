using WinConsoleUILibrary.Tools;
using WinConsoleUILibrary.Controls;
using WinConsoleUILibrary.Application;
using WinConsoleUILibrary.ConsoleService;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleExtendedWrapper<SystemConsoleWrapper> cew
                = new ConsoleExtendedWrapper<SystemConsoleWrapper>(SystemConsoleWrapper.Instance);
            
            SimpleConsoleApplication sca = new SimpleConsoleApplication();

            sca.AddControlToWindow(new InputField<SystemConsoleWrapper>(10, new Position(20, 20), cew))
                .AddControlToWindow(new InputField<SystemConsoleWrapper>(15, new Position(20, 21),cew));
            sca.Run();
        }
    }
}
