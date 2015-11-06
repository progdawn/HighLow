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
    //holds variables for computer's numbers
    class Computer
    {
        //I would love to do arrays on this!!!
        private static int numberLow1 = 1; //low number for game 1
        private static int numberHigh1 = 10; //high number for game 1
        private static int numberLow2 = 1; //low number for game 2
        private static int numberHigh2 = 50; //high number for game 2
        private static int numberLow3 = 1; //low number for game 3
        private static int numberHigh3 = 100; //high number for game 3
        private static int computerNumber = 0; //number that the computer "picks"
        Random cpuRandom = new Random(); //random number generator

        //default constructor
        public Computer()
        {

        }

        public int NumberLow1
        {
            get
            {
                return numberLow1;
            }
            set
            {
                numberLow1 = value;
            }
        }

        public int NumberHigh1
        {
            get
            {
                return numberHigh1;
            }
            set
            {
                numberHigh1 = value;
            }
        }

        public int NumberLow2
        {
            get
            {
                return numberLow2;
            }
            set
            {
                numberLow2 = value;
            }
        }

        public int NumberHigh2
        {
            get
            {
                return numberHigh2;
            }
            set
            {
                numberHigh2 = value;
            }
        }

        public int NumberLow3
        {
            get
            {
                return numberLow3;
            }
            set
            {
                numberLow3 = value;
            }
        }

        public int NumberHigh3
        {
            get
            {
                return numberHigh3;
            }
            set
            {
                numberHigh3 = value;
            }
        }

        public int ComputerNumber
        {
            get
            {
                return computerNumber;
            }
            set
            {
                computerNumber = value;
            }
        }

        //sets computer number for first game
        public void SetComputerNumber1()
        {
            computerNumber = cpuRandom.Next(numberLow1, numberHigh1);
        }

        //sets computer number for second game
        public void SetComputerNumber2()
        {
            computerNumber = cpuRandom.Next(numberLow2, numberHigh2);
        }

        //sets computer number for third game
        public void SetComputerNumber3()
        {
            computerNumber = cpuRandom.Next(numberLow3, numberHigh3);
        }
    }
}
