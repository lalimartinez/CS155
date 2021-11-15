/// Chapter No. 10		Exercise No. 1
/// File Name: OgreAlien.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write an Ogre Alien class that extends the Alien class and stores information about an Ogre Alien.
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Override the GetDamage method to return the amount of damage an Ogre Alien does
/// 3) Override the ToString method to display an Ogre Alien
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek12
{
    class OgreAlien : Alien
    {
        private const int DAMAGE = 6;

        //Constructor 
        public OgreAlien(int health, string name)
        {
            Health = health;
            Name = name;
        }

        //Method to get amount of damage done 
        public override int GetDamage()
        {
            return DAMAGE;
        }

        //toString method  
        public override string ToString()
        {
            return "~~Ogre Alien~~" +
            "\nName: " + Name +
            "\nHealth: " + Health;
        }
    }
}
