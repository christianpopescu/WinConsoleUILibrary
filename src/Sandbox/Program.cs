using System;
using WinConsoleUILibrary.Tools;
using WinConsoleUILibrary.Controls;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConsoleExtension.WriteAt(new Position(10,10),true,"Test of Console Extension");
            InputField ifld1 = new InputField(10,new Position(20,20));
            InputField ifld2 = new InputField(15,new Position(20,21));

            Window wmain = new Window();
            wmain.AddControl(ifld1).AddControl(ifld2);

            InputField ifld = ifld1;
            Console.CursorVisible = false;
            //ConsoleKey ck;
            ConsoleKeyInfo cki;
            //char c='\0';
            //Func<ConsoleKey> le = () => {var cc = Console.ReadKey(true); c = cc.KeyChar; return cc.Key;};

            //TODO:
            // Objective: Have some functionality that allows to get some input apply some processing to the input and
            // show the results
            // - add windows object to manage the controls - OK
            // - move loop to window
            // - add focus management
            // - show whe control has the focus
            // - add button 
            // - add scroll text control
            wmain.Run();

        }
    }
}
