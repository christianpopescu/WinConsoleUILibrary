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
            ConsoleKey ck;
            char c='\0';
            Func<ConsoleKey> le = () => {var cc = Console.ReadKey(true); c = cc.KeyChar; return cc.Key;};
            while ((ck = le())!= ConsoleKey.Escape)
            {
                if (c != '\0' && c != '\b' && c != '\t')
                {
                    ifld.AddChar(c);
                    ifld.Draw();
                }
                else if (ck == ConsoleKey.Backspace)
                {
                    ifld.DeleteLeft();
                    ifld.Draw();
                }
               
                if (ck == ConsoleKey.Tab) 
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
            }
        }
    }
}
