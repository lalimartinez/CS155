/// Chapter No. 10		Exercise No. 1
/// File Name: SnakeAlien.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write a Snake Alien class that extends the Alien class and stores information about a Snake Alien.
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Override the GetDamage method to return the amount of damage a Snake Alien does
/// 3) Override the ToString method to display a Snake Alien
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek12
{
    class SnakeAlien : Alien
    {
        private const int DAMAGE = 10;

        //Constructor 
        public SnakeAlien(int health, string name)
        {
            Health = health;
            Name = name;
        }

        //Method to get damage 
        public override int GetDamage()
        {
            return DAMAGE;
        }

        //toString method  
        public override string ToString()
        {
            return "~~Snake Alien~~" +
            "\nName: " + Name +
            "\nHealth: " + Health;
        }
    }
}
