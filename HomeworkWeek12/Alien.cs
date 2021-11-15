/// Chapter No. 10		Exercise No. 1
/// File Name: Alien.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write an Alien class that stores information about an Alien.
/// 
/// Overall Plan:
/// 1) Write 2 constructors: One no argument constructor and one for the instance variables.
/// 2) Write the getters and setters using properties
/// 3) Write a GetDamage method that returns the amount of damage an alien does
/// 4) Override the ToString method to display an Alien
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek12
{
    class Alien
    {
        private int health;
        private string name;

        //Empty constructor 
        public Alien() { }

        //Overloaded constructor
        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        //Getters and setters
        public int Health { get => health; set => health = value; }
        public string Name { get => name; set => name = value; }

        //GetDamage method 
        public virtual int GetDamage()
        {
            return 0;
        }

        //toString method  
        public override string ToString()
        {
            return "~~Alien~~" +
            "\nName: " + name +
            "\nHealth: " + health;
        }
    }
}
