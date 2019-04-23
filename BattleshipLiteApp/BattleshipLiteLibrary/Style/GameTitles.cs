using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Style
{
    public class GameTitles
    {
        public static void BattleshipOpeningTitle()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "Battleship Console Game";
            Console.WriteLine(); // breakline
            string battleShipStartGraphic =
                 @"
                        ########     ###    ######## ######## ##       ########  ######  ##     ## #### ########  
                        ##     ##   ## ##      ##       ##    ##       ##       ##    ## ##     ##  ##  ##     ## 
                        ##     ##  ##   ##     ##       ##    ##       ##       ##       ##     ##  ##  ##     ## 
                        ########  ##     ##    ##       ##    ##       ######    ######  #########  ##  ########  
                        ##     ## #########    ##       ##    ##       ##             ## ##     ##  ##  ##        
                        ##     ## ##     ##    ##       ##    ##       ##       ##    ## ##     ##  ##  ##        
                        ########  ##     ##    ##       ##    ######## ########  ######  ##     ## #### ##        
                ";

            typeWritter(battleShipStartGraphic);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

        } // method end

        public static void typeWritter(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(1);

            }

        }


    }
}
