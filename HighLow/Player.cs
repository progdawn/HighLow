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
    class Player
    {
        private static int numberOfGuesses = 0; //keeps track of number of guesses
        private static int guess = 0; //player's guess
        private static string newGame = "Y"; //used to play another game
        private static int gameSelected = 0; //the game that the user chose to play
        private static bool playerWin = true; //keeps track of if player won

        //default constructor
        public Player()
        {

        }

        public int GameSelected
        {
            get
            {
                return gameSelected;
            }
            set
            {
                gameSelected = value;
            }
        }

        public int Guess
        {
            get
            {
                return guess;
            }
            set
            {
                guess = value;
            }
        }

        public int NumberOfGuesses
        {
            get
            {
                return numberOfGuesses;
            }
            set
            {
                numberOfGuesses = value;
            }
        }

        public string NewGame
        {
            get
            {
                return newGame;
            }
            set
            {
                newGame = value;
            }
        }

        public bool PlayerWin
        {
            get
            {
                return playerWin;
            }
            set
            {
                playerWin = value;
            }
        }
    }
}
