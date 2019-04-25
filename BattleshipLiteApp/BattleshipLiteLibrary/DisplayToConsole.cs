using BattleshipLiteLibrary.Models;
using System;
using System.Globalization;
using BattleshipLiteLibrary.Style;

namespace BattleshipLiteLibrary
{
    public static class DisplayToConsole
    {
        public static void WelcomeMessage()
        {
            CenterText.centerText("Welcome to Battleship Lite");
            CenterText.centerText("Created by Kiron Roy");
            Console.WriteLine("");
        }

        public static string AskForUsersName()
        {
            Console.Write("  What is your name: ");
            string outputRaw = Console.ReadLine().Trim();
            string output = new CultureInfo("en-US").TextInfo.ToTitleCase(outputRaw);

            return output;
        }

        public static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"  Player information for {playerTitle}");

            // Ask user for their name
            output.UsersName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements

            PlaceShips(output);

            // Clear
            Console.Clear();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"  Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine().Trim();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("  Error: " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("  That was not a valid location.  Please try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }

    }
}
