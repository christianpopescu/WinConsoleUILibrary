using System;

namespace WinConsoleUILibrary.Misc
{
    public static class StringExtension 
    {
        public static string SafeSubstring(this String str, int Index, int Length) 
        {
            if (str.Length-1 < Index) return "";
            return str.Substring(Index, Math.Min(str.Length-Index, Length));

        }
    }
}
