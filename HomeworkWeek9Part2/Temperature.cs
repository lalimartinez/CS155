/// Chapter No. 7		Exercise No. 2
/// File Name: Temperature.cs
/// @author: Zitlali Martinez
/// Date:  October 23, 2021
///
/// Problem Statement: Write a Temperature class that stores a temperature and which scale it is on.
/// 
/// Overall Plan:
/// 1) Write four constructors: a no argument one, one for each instance variable, and one for both instance variables
/// 2) Write two getters: one to get the temperature in fahrenheit and one to get it in celsius
/// 3) Write three set methods: one for each instance variable and one to set both at the same time
/// 4) Write a toString method to display the object
/// 5) Write an equals method to compare two temperature objects
/// 

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeworkWeek9Part2
{
    class Temperature
    {
        private double temp;
        private char scale;

        //Empty constructor
        public Temperature()
        {
            temp = 0.0;
            scale = 'C';
        }

        //Constructor for temp variable only
        public Temperature(double _temp)
        {
            temp = _temp;
            scale = 'C';
        }

        //Constructor for scale variable only
        public Temperature(char _scale)
        {
            temp = 0.0;
            scale = _scale;
        }

        //Constructor with both instance variables 
        public Temperature(double _temp, char _scale)
        {
            temp = _temp;
            scale = _scale;
        }

        //Getter to get temp in celsius
        public double getCelsiusTemp()
        {
            if (scale == 'C')
                return Math.Round(temp, 1);
            else
            {
                double tempC;
                tempC = (5 * (temp - 32)) / 9;
                return Math.Round(tempC, 1);
            }
        }

        //Getter to get temp in fahrenheit
        public double getFahrenheitTemp()
        {
            if (scale == 'F')
                return Math.Round(temp, 1);
            else
            {
                double tempF;
                tempF = (temp * (5 / 9)) + 32;
                return Math.Round(tempF, 1);
            }
        }

        //Setters
        public void setTemp(double _temp)
        {
            temp = _temp;
        }

        public void setScale(char _scale)
        {
            scale = _scale;
        }

        public void setAll(double _temp, char _scale)
        {
            temp = _temp;
            scale = _scale;
        }

        //toString method
        public string toString()
        {
            return "Temperature: " + temp + scale;
        }

        //Equals method
        public bool equals(Temperature other)
        {
            return temp == other.temp && scale == other.scale;
        }
    }
}
