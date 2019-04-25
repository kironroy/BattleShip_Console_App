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
            DisplayToConsole.WelcomeMessage();

            PlayerInfoModel activePlayer = DisplayToConsole.CreatePlayer("Player 1");
            PlayerInfoModel opponent = DisplayToConsole.CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                DisplayShotGrid(activePlayer);

                RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {


                    // Use Tuple swap positions
                    (activePlayer, opponent) = (opponent, activePlayer);


                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

            Console.ForegroundColor = ConsoleColor.Blue;

            DisplayShotGrid(winner);

            GameTitles.BattleshipEndingTitle();

            Console.ReadLine();
        }

        // private methods

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"  Congratulations to {winner.UsersName} for winning!");
            Console.WriteLine($"  {winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
            Console.WriteLine();
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid Shot Location.  Please try again.");
                }

            } while (isValidShot == false);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);
        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"  {row}{column} is a Hit!");
            }
            else
            {
                Console.WriteLine($"  {row}{column} is a miss.");

            }

            Console.WriteLine();
        }

        private static string AskForShot(PlayerInfoModel player)
        {
            Console.Write($"  {player.UsersName}, please enter your shot selection: ");
            string output = Console.ReadLine().Trim();

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
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");

                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

        }




    }
}










