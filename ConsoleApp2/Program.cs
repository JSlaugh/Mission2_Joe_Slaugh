// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Schema;

namespace DiceRoller
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = Convert.ToInt32(Console.ReadLine());
            int[] rolledNums = new int[numberOfRolls];

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = "+numberOfRolls+".\n");
    
            /// Generate dice rolls for the requested number of rolls
            for (int icount = 0; icount < numberOfRolls; icount++)
            {
                Random rnd = new Random();
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int total = dice1+ dice2;
                /// Insert Dice Roll total for both dice into array
                rolledNums[icount] = total;
            }
            /// Loop going through options 2 through 13
            for (int icount2 = 2; icount2 < 13; icount2++)
            {
                int icount3 = 0;
                string astrikOutput = "";
                int percent = 0;
                /// going through the array and comparing individual result to current option
                foreach (var item in rolledNums)
                {
                    if (icount2 == item)
                    {
                        ///if they match add a total to that options count
                        icount3++;
                    }
                }
                /// create a percentage over all 
                percent = icount3 * 100 / numberOfRolls;
                /// loop generating * output  
                for (int icount4 = 0; icount4 < percent; icount4++)
                {
                    if (percent != 0)
                    {
                        astrikOutput += "*";
                    }

                }
                Console.WriteLine(icount2 + ": " + astrikOutput);
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}