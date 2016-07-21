using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Johaen Gnanakumar
 * Date: July 13, 2016
 * StudentID: 300880309
 * Description: Added tabular Model and fixed for loop
 * Version: 0.02
 */
namespace COMP123_S2016_Assignment4
{
    class Program
    {
        /**
         * @static
         * @method Main
         * @returns {void}
         */
        static void Main(string[] args)
        {
            Dice();

        }

        /**
 * <summary>
 * This dice method creates a console menu that allows the user to choose
 * a Lotto game to execute.
 * </summary>
 * 
 * @static
 * @method Dice
 * @returns {void}
 */
        public static void Dice()
        {

            // can only get sums of 2 to 12
            int[] tally = new int[11];

            Random rnd = new Random();
            for (int counter = 0; counter <= 36000; counter++)
            {



                int DiceOne = rnd.Next(1, 7);
                int DiceTwo = rnd.Next(1, 7);
                int sum = DiceOne + DiceTwo;

                // we roll sums of 2 - 12
                //our array which holds tallies for sums 2-12 has 11 elements ranging from 0-10
                //therefore, we need to subtract 2 from the sum to correspond to the matching index in the  array
                // ++ to increment tally(counter) of the rolled sum
                tally[sum - 2]++;


            }
            Console.WriteLine(" ================================");
            Console.WriteLine("| {0,5} | {1,-23}|", "Sum", "Number of Times Rolled");
            Console.WriteLine(" ================================");
            for (int counter = 0; counter < tally.Length; counter++)
            {
                Console.WriteLine("| {0,5} | {1,-23}|", counter + 2, tally[counter]);
                Console.WriteLine(" --------------------------------");


            }
        }

    }
}
