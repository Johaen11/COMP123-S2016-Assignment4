using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Johaen Gnanakumar
 * Date: July 12, 2016
 * StudentID: 300880309
 * Description: Added for loop
 * Version: 0.01
 */
namespace COMP123_S2016_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice();
            
        }
            

            public static void Dice() {
            
            int[] tally = new int[36000];

            for (int counter = 0; counter <= 36000; counter++)
            {
                Random rnd = new Random();

                int DiceOne = rnd.Next(1, 7);
                int DiceTwo = rnd.Next(1, 7);

      tally[36000] = DiceOne + DiceTwo;

            }

        }
    
    }
}
