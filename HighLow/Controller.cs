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
    class Controller
    {
        Player player1 = new Player();
        Computer cpu = new Computer();
        UserInterface ui = new UserInterface();

        //default constructor
        public Controller()
        {

        }

        //controls the game 
        public void MainGame()
        {
            while (player1.NewGame == "Y" || player1.NewGame == "y")
            {
                ui.SelectNewGame(); //user selects new game
                ComputerPicks(); //generate number depending on game
                player1.NumberOfGuesses++; //since ComputerPicks prompts for a guess, this increases the guess count

                //while user has decided not to quit current game
                while (player1.Guess != 0)
                {
                    if (player1.Guess == cpu.ComputerNumber) //if user guessed right
                    {
                        ui.PlayerWon();
                        player1.Guess = 0;
                    }
                    else if (player1.Guess < cpu.ComputerNumber)
                    {
                        player1.NumberOfGuesses++;
                        ui.PlayerLow();
                        if (player1.Guess == 0) //if user chose to quit
                        {
                            player1.PlayerWin = false; //sets flag to loss
                            player1.NumberOfGuesses--; //removes the guess increment, since quitting isn't really a guess
                        }

                    }
                    else
                    {
                        player1.NumberOfGuesses++;
                        ui.PlayerHigh();
                        if (player1.Guess == 0)
                        {
                            player1.PlayerWin = false; //sets flag to loss
                            player1.NumberOfGuesses--; //removes the guess increment, since quitting isn't really a guess
                        }
                    }
                }
                FinalReport(); //prints final report
                ResetNumbers(); //resets variables
            }
        }

        //creates number for computer, depending on the game the user selected
        public void ComputerPicks()
        {
            if (player1.GameSelected == 1)
            {
                cpu.SetComputerNumber1();
                ui.ComputerPicking(cpu.NumberLow1, cpu.NumberHigh1);
                ui.FirstGuess(cpu.NumberLow1, cpu.NumberHigh1);
            }

            else if (player1.GameSelected == 2)
            {
                cpu.SetComputerNumber2();
                ui.ComputerPicking(cpu.NumberLow2, cpu.NumberHigh2);
                ui.FirstGuess(cpu.NumberLow2, cpu.NumberHigh2);
            }

            else
            {
                cpu.SetComputerNumber3();
                ui.ComputerPicking(cpu.NumberLow3, cpu.NumberHigh3);
                ui.FirstGuess(cpu.NumberLow3, cpu.NumberHigh3);
            }
        }

        //prints report, depending on if the user won, or quit
        public void FinalReport()
        {
            if (player1.PlayerWin)
            {
                ui.ReportForWin();
            }
            else
            {
                ui.ReportForLoss();
            }
        }

        //resets variables for new game
        public void ResetNumbers()
        {
            player1.NumberOfGuesses = 0;
            player1.Guess = 0;
            player1.PlayerWin = true;
        }
    }
}
