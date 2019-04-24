using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using BattleshipLiteLibrary.Style;
using System;
using System.Globalization;

namespace BattleShipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitles.BattleshipOpeningTitle();
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
             
                DisplayShotGrid(activePlayer);

                RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    // Swap using a temp variable use Tuple
                    (activePlayer, opponent) = (opponent, activePlayer);


                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congragulations to {winner.UsersName} for winning!");
            Console.WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner) } shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot();
                (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                isValidShot = GameLogic.Validateshot(activePlayer, row, column);

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid Shot Location.  Please try again.");
                }

            } while (isValidShot == false);
        
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkshotResult(activePlayer, row, column, isAHit);
        }

        private static string AskForShot()
        {
            Console.Write("What is your name: ");
            string outputRaw = Console.ReadLine().Trim();
            string output = new CultureInfo("en-US").TextInfo.ToTitleCase(outputRaw);

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;

                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotLetter}");

                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O ");
                }
                else
                {
                    Console.Write(" ? ");
                }
            }
        }

        private static void WelcomeMessage()
        {

            CenterText.centerText("Welcome to Battleship Lite");
            CenterText.centerText("Created by Kiron Roy");
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            CenterText.centerText($"Player information for {playerTitle}");

            // Ask the user for their name
            output.UsersName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShips(output);

            // Clear the screen
            Console.Clear();

            return output;
        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location.  Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }
}

