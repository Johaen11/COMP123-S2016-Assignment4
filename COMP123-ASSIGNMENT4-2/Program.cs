using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: Johaen Gnanakumar
 * Date: July 20, 2016
 * StudentID: 300880309
 * Description: a	C#	project	to	assign	seats	on	each	flight	of	the	airline’s	only	plane
 * Version: 0.01
 */
namespace COMP123_ASSIGNMENT4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> seating = new List<string>();
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter <= 4)
                {
                    seating.Add("Economy");
                }
                else
                {
                    seating.Add("First Class");
                }
                

            }
            List<string> assignedSeat = new List<string>();

            DisplayMenu(seating, assignedSeat);

        }

        public static void DisplayMenu(List<string> seating, List<string> assignedSeat)
        {
            bool ContinueLoop = true;
            while (ContinueLoop == true)
            {
                Console.WriteLine("1. First Class");

                Console.WriteLine("2. Economy");

                Console.WriteLine("3. Exit");

                Console.WriteLine("Please Select Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        firstClass(seating, assignedSeat);
                        break;
                    case 2:
                        Economy(seating, assignedSeat);
                        break;
                    case 3:
                        ContinueLoop = false;
                        break;


                }

            }
        }

        public static void firstClass(List<string> seats, List<string> Assigned)
        {
            if (seats.Remove("First Class"))
            {
                Assigned.Add("First Class");
                Console.WriteLine("You have been added to first class");
            }
            else
            {
                Console.WriteLine("Is it okay to be placed in the economy section");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Economy(seats,Assigned);
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours");
                }
            }
        }
        public static void Economy(List<string> seat, List<string> Assigned)
        {

            if (seat.Remove("Economy"))
            {
                Assigned.Add("Economy");
                Console.WriteLine("You have been added to economy class");



            }
            else
            {
                Console.WriteLine("Is it okay to be placed in the First Class section");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    firstClass(seat, Assigned);
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours");
                }
            }
        }

    }
}
