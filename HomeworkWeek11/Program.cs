/// Chapter No. 9		Exercise No. 1
/// File Name: VehicleDriver.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a program that creates an object of each class and tests the methods.
/// 
/// Overall Plan:
/// 1) Create a person object
/// 2) Create a vehicle object
/// 3) Create a truck object
/// 4) Display each object to the screen
/// 5) Create a second truck object
/// 6) Compare the two truck objects to see if they are the same
/// 
using System;

namespace HomeworkWeek11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Person object 
            Person me = new Person("Lali");

            //Create a vehicle object 
            Vehicle myVehicle = new Vehicle(Manufacturer.Audi, 4, me);

            //Create a truck object
            Truck myTruck = new Truck(Manufacturer.Toyota, 4, me, 2, 150);

            //Display objects to screen 
            Console.WriteLine(me);
            Console.WriteLine("\n" + myVehicle);
            Console.WriteLine("\n" + myTruck);

            //Create another truck and compare them 
            Truck otherTruck = new Truck(Manufacturer.Ford, 4, me, 2, 150);
            if (myTruck.Equals(otherTruck))
                Console.WriteLine("\nThe 2 trucks are the same.");
            else
                Console.WriteLine("\nThe 2 trucks are not the same.");

            Console.ReadLine();
        }

    }
}
