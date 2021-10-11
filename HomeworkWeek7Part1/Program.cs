/// Chapter No. 6		Exercise No. 1
/// File Name: CounterDriver.cs
/// @author: Zitlali Martinez
/// Date:  October 10, 2021
///
/// Problem Statement: Write a driver program with a menu to test each method of the Counter class.
/// 
/// Overall Plan:
/// 1) Create two counter objects 
/// 2) Display menu of choices for one counter object and prompt user for a choice
/// 3) Use a switch statement to switch between choices
/// 4) For choice 1 increase the count
/// 5) For choice 2 decrease the count
/// 6) For choice 3 display the current count
/// 7) For choice 4 reset count to zero
/// 8) For choice 5 break out of the menu loop
/// 9) As a default, tell user their choice must be between 1-5
/// 10) While choice isn't 5, keep displaying menu
/// 11) Display the final count of the first counter object and the count of the second object
/// 12) Compare the two counter objects to see if they are the same
/// 
using System;

namespace HomeworkWeek7Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            //Create Counter objects and set to zero
            Counter count1 = new Counter();
            count1.setCount();
            Counter count2 = new Counter();
            count2.setCount();


            do
            {
                //Create menu
                Console.WriteLine("\nChoose one of the following." +
                    "\n1) Increase count by 1." +
                    "\n2) Decrease count by 1." +
                    "\n3) Display current count." +
                    "\n4) Reset counter to zero." +
                    "\n5) Exit." +
                    "\nEnter choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    //Increase count by 1
                    case 1:
                        count1.increaseCount();
                        break;

                    //Decrease count by 1
                    case 2:
                        count1.decreaseCount();
                        break;

                    //Display current count
                    case 3:
                        Console.WriteLine();
                        count1.currentCount();
                        break;

                    //Reset count to zero
                    case 4:
                        count1.setCount();
                        break;

                    //Exit
                    case 5:
                        Console.WriteLine("\nExiting.");
                        break;

                    //If choice enters is not 1-5
                    default:
                        Console.WriteLine("\nChoice must be between 1-5");
                        break;
                }
            } while (choice != 5);

            //Display final count of count1 using toString method
            Console.WriteLine("\nThe final count of your counter.\n" + count1.ToString());

            //Display count of second count object
            Console.WriteLine("The count of the second counter is " + count2.getCount());

            //Compare counters using equals method
            Console.WriteLine("\nAre the two counters the same?");
            if (count1.Equals(count2))
                Console.WriteLine("The counters are the same.");
            else
                Console.WriteLine("The counters are not the same.");

            Console.ReadLine();

        }
    }
}
