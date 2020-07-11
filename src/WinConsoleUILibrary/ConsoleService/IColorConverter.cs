using System;
using System.Collections.Generic;
using System.Text;

namespace WinConsoleUILibrary.ConsoleService
{
    public interface IColorConverter<TC> where TC : System.Enum
    {
        TC FromAbstract(AbstractColor color);
        AbstractColor ToAbstract(TC color);
    }
}
