/// Chapter No. 3		Exercise No. 2
/// File Name: ChangeCalculator.cs
/// @author: Zitlali Martinez
/// Date:  September 19, 2021
///
/// Problem Statement: Ask user to enter the price of an item and calculate the change given to them.
/// 
/// Overall Plan:
/// 1) Prompt user for the price of the item
/// 2) Calculate the change
/// 3) Calculate the number of quarters that will be given
/// 4) Calculate the number of dimes that will be given
/// 5) Calculate the number of nickels that will be given
/// 6) Print the change to the screen
///
using System;

namespace HomeworkWeek4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int price, cents;
            int quarters, dimes, nickels;
           
            Console.WriteLine("Enter the price of the item (between 25 cents and a dollar, in increments of 5): ");
            //Read input and convert to int
            price = Int32.Parse(Console.ReadLine());

            //Calculate the change
            cents = 100 - price;

            //Calculate number of quarters
            quarters = cents / 25;
            //Calculate leftover change
            cents %= 25;

            //Calculate number of dimes
            dimes = cents / 10;
            cents %= 10;

            //Calculate the number of nickels
            nickels = cents / 5;
      
            //Display change to screen
            Console.WriteLine("Your change is:\n" + quarters + " quarters\n" + dimes + " dimes\n" + nickels + " nickels");

            Console.ReadLine();
        }
    }
}
