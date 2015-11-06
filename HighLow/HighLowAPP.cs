//Dawn Myers
//ITDEV110
//Assignment 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class HighLowAPP
    {
        static void Main(string[] args)
        {
            Admin setup = new Admin();
            Controller game = new Controller();

            setup.ConsoleSetup(); //sets up console size, title, background and foreground color
            setup.Intro(); //displays intro to application
            game.MainGame(); //hands off application to the controller
            setup.Goodbye(); //exit screen
        }
    }
}
