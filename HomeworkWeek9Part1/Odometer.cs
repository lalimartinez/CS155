/// Chapter No. 7		Exercise No. 1
/// File Name: Odometer.cs
/// @author: Zitlali Martinez
/// Date:  October 23, 2021
///
/// Problem Statement: Write an Odometer class to keep track of fuel usage and miles.
/// 
/// Overall Plan:
/// 1) Write two constructors: one no argument one and one for both instance variables
/// 2) Write the getters and setters using properties
/// 3) Write a reset method that sets fuel used and miles to zero
/// 4) Write an add method that adds more fuel and miles to the current amount
/// 5) Write an MPG method that return the MPG
/// 6) Write a toString method to display the odometer object
/// 

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek9Part1
{
    class Odometer
    {
        private int miles;
        private double fuelUsed;

        //No argument constructor
        public Odometer() { }

        //Overloaded constructor 
        public Odometer(int _miles, double _fuelUsed)
        {
            miles = _miles;
            fuelUsed = _fuelUsed;
        }

        //Getters and Setters
        public int Miles { get => miles; set => miles = value; }

        public double FuelUsed { get => fuelUsed; set => fuelUsed = value; }

        //Reset method to set miles and fuel to zero
        public void reset()
        {
            miles = 0;
            fuelUsed = 0;
        }

        //Add method to add more miles and fuel
        public void add(int m, double f)
        {
            miles += m;
            fuelUsed += f;
        }

        //MPG method
        public double MPG()
        {
            return (miles / fuelUsed);
        }

        //toString method
        public string toString()
        {
            return " " + miles + " Miles driven " + fuelUsed + " fuel used";
        }
    }
}
