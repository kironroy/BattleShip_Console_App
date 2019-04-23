﻿using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using BattleshipLiteLibrary.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleShipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitles.BattleshipOpeningTitle();
            WelcomeMessage();

            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");

            Console.ReadLine();
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

