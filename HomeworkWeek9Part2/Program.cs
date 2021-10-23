/// Chapter No. 7		Exercise No. 2
/// File Name: TemperatureDriver.cs
/// @author: Zitlali Martinez
/// Date:  October 23, 2021
///
/// Problem Statement: Write a driver program to test each method in the Temperature class.
/// 
/// Overall Plan:
/// 1) Create a temperature object using the no argument constructor and display the object using the toString method 
/// 2) Display the first object's temperature in fahrenheit
/// 3) Create a second object using the constructor with both instance variables
/// 4) Display the temperarure for the second object in both fahrenheit and celsius
/// 5) Create two more objects using the constructors that only take in one instance variable
/// 6) Use the three set methods on the previous two objects
/// 7) Use the equals method to compare two temperature objects
/// 

using System;

namespace HomeworkWeek9Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create temp object and print using toString
            Temperature tempC = new Temperature();
            Console.WriteLine(tempC.toString());
            //Print temp in Fahrenheit
            Console.WriteLine("Temp in Fahrenheit: " + tempC.getFahrenheitTemp());

            //Create second temp object and use both get methods on it
            Temperature tempF = new Temperature(72, 'F');
            Console.WriteLine("\nFahrenheit Temperature: " + tempF.getFahrenheitTemp());
            Console.WriteLine("Celsius Temperature: " + tempF.getCelsiusTemp());

            //Create two more temp objects using constructors that only take in one parameter
            Temperature tempC2 = new Temperature(20.0);
            Console.WriteLine("\nTempC2\n" + tempC2.toString());
            Temperature tempF2 = new Temperature('F');
            Console.WriteLine("\nTempF2\n" + tempF2.toString());

            //Use set methods
            tempC2.setTemp(34.5);
            tempF2.setScale('C');
            Console.WriteLine("\nTempC2\n" + tempC2.toString());
            Console.WriteLine("\nTempF2\n" + tempF2.toString());
            tempF2.setAll(65.0, 'F');
            Console.WriteLine("\nTempF2\n" + tempF2.toString());

            //Use equals methods to compare two temp objects
            if (tempC.equals(tempC2))
                Console.WriteLine("\nTempC and TempC2 are the same.");
            else
                Console.WriteLine("\nTempC and TempC2 are not the same.");

            Console.ReadLine();
        }
    }
}
