/// Chapter No. 7		Lab No. 1
/// File Name: Pizza.cs
/// @author: Zitlali Martinez
/// Date:  October 25, 2021
///
/// Problem Statement: Write a Pizza class that stores the information for one pizza.
/// 
/// 
/// Overall Plan:
/// 1) Write two constructors: a no argument one and one for all the instance variables
/// 2) Write the getters and setters using properties
/// 3) Write a method to calculate the cost of the pizza
/// 4) Override the toString method to display the pizza information
///

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Week9Lab
{
    class Pizza
    {
        private string size;
        private int cheese;
        private int pepperoni;
        private int ham;

        //Empty constructor
        public Pizza() { }

        //Overloaded constructor 
        public Pizza(string _size, int _cheese, int _pepperoni, int _ham)
        {
            size = _size;
            cheese = _cheese;
            pepperoni = _pepperoni;
            ham = _ham;
        }

        //Getters and Setters
        public string Size { get => size; set => size = value; }
        public int Cheese { get => cheese; set => cheese = value; }
        public int Pepperoni { get => pepperoni; set => pepperoni = value; }
        public int Ham { get => ham; set => ham = value; }

        //Method to calculate cost 
        public double CalculateCost()
        {
            double cost = ((double)cheese * 2) + (pepperoni * 2) + (ham * 2);
            //If small add 10 to the cost
            if (size == "small")
                cost += 10.0;
            //Else if medium add 12 to the cost
            else if (size == "medium")
                cost += 12.0;
            //Else add 14 to cost for a large
            else
                cost += 14.0;
            return Math.Round(cost, 2);
        }

        //Overriden toString method 
        public string toString()
        {
            return "Pizza size: " + size
            + "\nCheese Toppings: " + cheese
            + "\nPepperoni Toppings: " + pepperoni
            + "\nHam Toppings: " + ham
            + "\nCost: $" + CalculateCost();
        }
    }
}
