using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HighLow
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "High Low!"; //window title
            Console.SetWindowSize(105, 25); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.DarkBlue; //background color of console
            Console.ForegroundColor = ConsoleColor.Yellow; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("Welcome to High Low!");
            Thread.Sleep(500);
            Console.WriteLine("In this game, you'll select a range of numbers.");
            Thread.Sleep(500);
            Console.WriteLine("The computer will then pick a number from that range.");
            Thread.Sleep(500);
            Console.WriteLine("You'll then have to guess what that number is!");
            Thread.Sleep(500);
            Console.Write("Press any key to continue >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for playing High Low!");
            Thread.Sleep(500);
            Console.Write("Shutting down");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
        }
    }
}
