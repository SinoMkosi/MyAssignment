using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssignment
{
    public class UIHelper
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("=======================================");
            Console.WriteLine("   [🔒] Stay Safe Online [🔒]");
            Console.WriteLine("=======================================");

            Console.ResetColor();
        }
    }
}
