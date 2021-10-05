using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ronaldo", "Messi", "Vela", "Vardy", "Hazard" };
            //string[] names = new string[3];
            double[] goals = { 50, 20, 45, 83, 93 };
            string[] club = { "Juventus", "Barcelona", "LA Galaxy", "Leichester", "Real Madrid" };
            double[] assist = { 79, 2, 45, 23, 35 };
            double[] gamesPlayed = { 35, 70, 50, 35, 70 };
            int playerSelection;
            string inputstring = "y";
            
            for (int x = 0; x < names.Length; x++)
            {
                WriteLine("{0,1}{1,15}", x + 1, names[x]);

            }

            while (inputstring == "y" || inputstring == "Y")
            {
                WriteLine("which player stats would you like to see?");
                bool res = int.TryParse(ReadLine(), out playerSelection);

                if (res== false)
                {
                    WriteLine("the character you inputed is incorrect");
                }

                else if (res)
                {
                    try
                    {
                        WriteLine("{0,1}{1,10}{2,20}{3,15}{4,15}", "Player", "Club", "Games Played", "Goals", "Assist");
                        WriteLine("{0,1}{1,15}{2,15}{3,15}{4,15}" + "", names[playerSelection - 1], club[playerSelection - 1], gamesPlayed[playerSelection - 1], goals[playerSelection - 1], assist[playerSelection - 1]);
                    }


                    catch (IndexOutOfRangeException a)
                    {
                        WriteLine("Must be a number between 1-5");
                    }

                }
                WriteLine("Would you like to make another selection?\n y-yes\n n-no");
                inputstring = ReadLine();

            } //closes while looop

            WriteLine("thank you for accepting Real Madrid is the greatest club ever!");


            ReadKey();
        }//closes main
    }
}
