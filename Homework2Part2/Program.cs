/// Chapter No. 2		Exercise No. 2
/// File Name: FarenheitToCelsius.cs
/// @author: Zitlali Martinez
/// Date:  September 12, 2021
///
/// Problem Statement: Ask user for a temperature in farenheit and convert it to celsius.
/// Display the celsius temperature to the screen.
/// 
/// Overall Plan:
/// 1) Print a welcome message to the screen
/// 2) Prompt user for a temperature in farenheit
/// 3) Convert the temperature to celsius
/// 4) Print the celsius temperature to the screen
///
using System;

namespace Homework2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("This program converts a farenheit temperature to celsius.");

            //Declare variables to hold temperarures
            int farenheit;
            double celsius;

            //Prompt user for temperature
            Console.WriteLine("Enter temperature in farenheit: ");

            //Read input from user and convert to int
            farenheit = Int32.Parse(Console.ReadLine());

            //Convert temperature to celsius
            celsius = (5 * ((double)farenheit - 32)) / 9;

            //Display celsius temp to screen
            Console.WriteLine("The temperature in celsius is: " + celsius);

            Console.ReadLine();
        }
    }
}
