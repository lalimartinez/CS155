/// Chapter No. 7		Lab No. 1
/// File Name: PizzaDriver.cs
/// @author: Zitlali Martinez
/// Date:  October 25, 2021
///
/// Problem Statement: Write a driver program to test the methods of the Pizza class.
/// 
/// 
/// Overall Plan:
/// 1) Create two pizza objects using both constructors
/// 2) Use the setter to set the information for one of the pizzas
/// 3) Use one the getter to get the size of the second pizza
/// 4) Calculate the cost of one the pizzas using the CalculateCost method
/// 5) Display the information of both pizzas using the toString method
///

using System;

namespace Week9Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create pizzas using constructors
            Pizza myPizza = new Pizza();
            Pizza otherPizza = new Pizza("medium", 2, 3, 3);

            //Use set on myPizza
            myPizza.Size = "small";
            myPizza.Cheese = 1;
            myPizza.Pepperoni = 3;
            myPizza.Ham = 2;

            //Use get method on otherPizza 
            Console.WriteLine("Size of other pizza: " + otherPizza.Size);

            //Use calculate cost method 
            Console.WriteLine("Cost of myPizza: $" + myPizza.CalculateCost());

            //Use toString methods 
            Console.WriteLine("\nMy Pizza\n" + myPizza.toString());
            Console.WriteLine("\nOther Pizza\n" + otherPizza.toString());

            Console.ReadLine();
        }
    }
}
