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

            Console.ForegroundColor = ConsoleColor.Blue;

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

            Console.WriteLine(battleShipStartGraphic);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

        } 

        public static void BattleshipEndingTitle()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "Battleship Console Game";
            Console.WriteLine(); // breakline
            string battleShipGameOverGraphic =
                 @"
                       
                          _______      ___      .___  ___.  _______   ______   ____    ____  _______ .______      
                         /  _____|    /   \     |   \/   | |   ____| /  __  \  \   \  /   / |   ____||   _  \     
                        |  |  __     /  ^  \    |  \  /  | |  |__   |  |  |  |  \   \/   /  |  |__   |  |_)  |    
                        |  | |_ |   /  /_\  \   |  |\/|  | |   __|  |  |  |  |   \      /   |   __|  |      /     
                        |  |__| |  /  _____  \  |  |  |  | |  |____ |  `--'  |    \    /    |  |____ |  |\  \----.
                         \______| /__/     \__\ |__|  |__| |_______| \______/      \__/     |_______|| _| `._____|
                                                                                          
   
                ";

            typeWritter(battleShipGameOverGraphic);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

        } 

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
