using System;
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
            ConsoleExtendedWrapper<SystemConsoleWrapper, System.ConsoleColor> cew
                = new ConsoleExtendedWrapper<SystemConsoleWrapper, System.ConsoleColor>(SystemConsoleWrapper.Instance);
            
            SimpleConsoleApplication sca = new SimpleConsoleApplication();

            sca.AddControlToWindow(new InputField<SystemConsoleWrapper, System.ConsoleColor>(10, new Position(20, 20), cew))
                .AddControlToWindow(new InputField<SystemConsoleWrapper, System.ConsoleColor>(15, new Position(20, 21),cew));
            sca.Run();
        }
    }
}
