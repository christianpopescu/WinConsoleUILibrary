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
            InputField ifld2 = new InputField(15,new Position(21,21));
            InputField ifld = ifld1;
            Console.CursorVisible = false;
            //ConsoleKey ck;
            ConsoleKeyInfo cki;
            //char c='\0';
            //Func<ConsoleKey> le = () => {var cc = Console.ReadKey(true); c = cc.KeyChar; return cc.Key;};
            while ((cki=Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                char c = cki.KeyChar;
                if (cki.Key == ConsoleKey.Tab) 
                {
                    if (object.ReferenceEquals(ifld, ifld1))
                    {
                        ifld = ifld2;
                    }
                    else
                    {
                        ifld = ifld1;
                    }
                }
                else
                ifld.SendKey(cki);
            }
        }
    }
}
