/// Chapter No. 7		Exercise No. 1
/// File Name: OdometerDriver.cs
/// @author: Zitlali Martinez
/// Date:  October 23, 2021
///
/// Problem Statement: Write a driver program to test each method in the Odometer class.
/// 
/// Overall Plan:
/// 1) Create an Odometer object using the no argument constructor
/// 2) Add fuel and miles to the object using the add method
/// 3) Print the MPG of the first object
/// 4) Create a second object and add to it
/// 5) Reset the first Odometer object
/// 6) Display the first object using the toString method
/// 

using System;

namespace HomeworkWeek9Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an odometer object and add to it
            Odometer trip1 = new Odometer();
            trip1.add(50, 10);
            //Print MPG 
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.MPG());
            //Create second odometer object 
            Odometer trip2 = new Odometer();
            trip2.add(100, 20);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG());
            //Reset first object
            trip1.reset();
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.toString());

            trip2.add(150, 0);
            Console.WriteLine("Fuel used for trip 2 is: " + trip2.MPG());

            Console.ReadLine();
        }
    }
}
