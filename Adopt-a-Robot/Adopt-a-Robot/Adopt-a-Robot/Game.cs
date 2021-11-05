﻿/* Adopt A Robot
 * Example code for PROG 101
 * Originally created by Janell Baxter
 * Game class refactored by _______________
 * Summer 2021
 */

using System;
using static System.Console;

namespace Adopt_a_Robot
{
    class Game
    {
        Player player;
        string GameTitle = "Adopt a bot!";

        public Game()
        {
            player = new Player();
        }
        public Game(string title)
        {
            GameTitle = title;
            player = new Player();
        }

        public void Start()
        {
            Title = GameTitle;
            playersname();
            greetplayer();



            WriteLine($"You are adopting a robot.");

            getname();
            setcolor();
            printsummary();
            

            

        }
        public void setcolor() {
            //get color for robot
            WriteLine("Type a number for a color: 1) Blue 2) Purple 3) Green 4) Brown 5) Black 6)Coral ");
            string choice = ReadLine();
            switch (choice)
            {
                case "1":
                    player.PlayerRobot.Color = "blue";
                    break;
                case "2":
                    player.PlayerRobot.Color = "purple";
                    break;
                case "3":
                    player.PlayerRobot.Color = "green";
                    break;
                case "4":
                    player.PlayerRobot.Color = "brown";
                    break;
                case "5":
                    player.PlayerRobot.Color = "black";
                    break;
                case "6":
                    player.PlayerRobot.Color = "coral";
                    break;
                default:
                    player.PlayerRobot.Color = "silver";
                    break;
            }
        }
        public void printsummary()
        {
            //print summary of player's robot (name and color)
            Clear();
            WriteLine($"Congratulations {player.Name}! You have adopted a {player.PlayerRobot.Color} robot named {player.PlayerRobot.Name}. Press any key to exit.");
            ReadKey(); 
        }

        public void playersname()
        {
            //Get player's name and save it to the instance of player class
            WriteLine("Welcome to Adopt a Robot!");
            WriteLine("What is your name?");
            player.Name = Console.ReadLine();

        }
        public void greetplayer()
        {
            //greet player with the name they entered
            WriteLine("Glad to meet you " + player.Name);

     
    
        
        }
        public void getname()
        {
            //get name for player's robot
            WriteLine("What name would you like your robot to have?");
            player.PlayerRobot.Name = ReadLine();
        }
    }   
    
}