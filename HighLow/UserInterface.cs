//Dawn Myers
//ITDEV110
//Assignment 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HighLow
{
    class UserInterface
    {
        Computer cpu = new Computer();
        Player player1 = new Player();

        //default constructor
        public UserInterface()
        {

        }

        //allows user to select new game
        public void SelectNewGame()
        {
            Console.WriteLine("Here are the games available:");
            Thread.Sleep(500);
            Console.WriteLine("\t1) {0} through {1}", cpu.NumberLow1, cpu.NumberHigh1);
            Thread.Sleep(500);
            Console.WriteLine("\t2) {0} through {1}", cpu.NumberLow2, cpu.NumberHigh2);
            Thread.Sleep(500);
            Console.WriteLine("\t3) {0} through {1}", cpu.NumberLow3, cpu.NumberHigh3);
            Console.Write("Please enter 1, 2, or 3 to select a game >> ");
            player1.GameSelected = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
            Console.Write("Press any key to continue >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //just flavor text to let user know computer picked a number
        public void ComputerPicking(int cpuLow, int cpuHigh)
        {
            Console.Write("The computer is now choosing a number between {0} and {1}", cpuLow, cpuHigh);
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("The computer has picked a number!");
            Thread.Sleep(500);
            Console.Write("Press any key to continue >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //text for first guess
        public void FirstGuess(int cpuLow, int cpuHigh)
        {
            Console.Write("Please enter a number between {0} and {1}, or press \"0\" to give up >> ", cpuLow, cpuHigh);
            player1.Guess = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
        }

        //if user won, use this
        public void ReportForWin()
        {
            Console.WriteLine("Congratulations on winning!");
            Thread.Sleep(500);
            Console.WriteLine("You guessed a total of {0} times.", player1.NumberOfGuesses);
            Thread.Sleep(500);
            Console.Write("If you'd like to play again, press \"Y\". To quit, press \"Q\" >> ");
            player1.NewGame = Console.ReadLine();
            Thread.Sleep(500);
            Console.Clear();
        }

        //if user quit the current game, use this
        public void ReportForLoss()
        {
            Console.Clear();
            Console.WriteLine("Congratulations on GIVING UP!");
            Thread.Sleep(500);
            Console.WriteLine("Since this game is too hard for you, maybe you should try \"Insert Fun\"?");
            Thread.Sleep(500);
            Console.WriteLine("You guessed a total of {0} times.", player1.NumberOfGuesses);
            Thread.Sleep(500);
            Console.WriteLine("The computer's number was {0}.", cpu.ComputerNumber);
            Thread.Sleep(500);
            Console.Write("If you'd like to play again, press \"Y\". To quit, press \"Q\" >> ");
            player1.NewGame = Console.ReadLine();
            Thread.Sleep(500);
            Console.Clear();
        }

        //if player guessed right, use this
        public void PlayerWon()
        {
            Console.Beep(500, 300);
            Console.Write("You guessed right! You won! Press any key to continue >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //if user guessed low, use this
        public void PlayerLow()
        {
            Console.Beep(100, 300);
            Console.Write("You guessed too low. Try again >> ");
            player1.Guess = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
        }

        //if user guessed high, use this
        public void PlayerHigh()
        {
            Console.Beep(999, 300);
            Console.Write("You guessed too high! Try again >> ");
            player1.Guess = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
        }
    }
}
