/// Chapter No. 10		Exercise No. 1
/// File Name: MarshallowManAlien.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write a Marshallow Man Alien class that extends the Alien class and stores information about a Marshallow Man Alien.
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Override the GetDamage method to return the amount of damage a Marshallow Man Alien does
/// 3) Override the ToString method to display a Marshallow Man Alien
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek12
{
    class MarshallowManAlien : Alien
    {
        private const int DAMAGE = 1;

        //Constructor 
        public MarshallowManAlien(int health, string name)
        {
            Health = health;
            Name = name;
        }

        //Method to return amount of damage done
        public override int GetDamage()
        {
            return DAMAGE;
        }

        //toString method  
        public override string ToString()
        {
            return "~~Marshallow Man Alien~~" +
            "\nName: " + Name +
            "\nHealth: " + Health;
        }
    }
}
