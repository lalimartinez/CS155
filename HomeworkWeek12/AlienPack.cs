/// Chapter No. 10		Exercise No. 1
/// File Name: AlienPack.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write an Alien Pack class that stores an array of Aliens.
/// 
/// Overall Plan:
/// 1) Write a constructor that takes in how many aliens there are
/// 2) Write a method to add a new alien to the pack
/// 3) Write a getter method
/// 4) Write a CalculateDamage method that calculates the amount of damage done by the aliens in the pack
/// 5) Write a method to display the alien pack to the screen
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek12
{
    class AlienPack
    {
        private Alien[] aliens;

        //Constructor
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        //Method to add a new alien to array
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        //Getter
        public Alien[] GetAliens()
        {
            return aliens;
        }

        //Method to calculate damage, returns how much damage is done all together
        public int CalculateDamage()
        {
            int damage = 0;
            foreach (Alien a in aliens)
                damage += a.GetDamage();

            return damage;
        }

        //Method that prints all aliens in array 
        public void DisplayAliens()
        {
            foreach (Alien a in aliens)
                Console.WriteLine(a + "\n");
        }
    }
}
