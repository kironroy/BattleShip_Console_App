using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary
{
    public class CenterText
    {
        public static void centerText(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine("\n");


            Console.WriteLine(message.PadLeft(spaces));
        }
    }
}
