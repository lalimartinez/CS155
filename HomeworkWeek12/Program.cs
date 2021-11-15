/// Chapter No. 10		Exercise No. 1
/// File Name: AlienDriver.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write a program that creates several aliens, adds them to the pack, and calculates the damage done.
/// 
/// Overall Plan:
/// 1) Create two MarshallowManAlien objects
/// 2) Create two OgreAlien objects
/// 3) Create two SnakeAlien objects
/// 4) Create an AlienPack object
/// 5) Add the aliens to the alien pack
/// 6) Display the aliens to the screen
/// 7) Calculate the damage done by the aliens and display it to the screen
/// 
using System;

namespace HomeworkWeek12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a couple aliens 
            MarshallowManAlien marshmellow = new MarshallowManAlien(100, "Marshmellow");
            OgreAlien ozzy = new OgreAlien(100, "Ozzy");
            SnakeAlien python = new SnakeAlien(100, "Python");
            SnakeAlien rattle = new SnakeAlien(87, "Rattle");
            MarshallowManAlien marshall = new MarshallowManAlien(98, "Marshall");
            OgreAlien oscar = new OgreAlien(76, "Oscar");

            //Create an alien pack 
            AlienPack aliens = new AlienPack(6);
            //Add the aliens to the alien pack 
            aliens.AddAlien(marshmellow, 0);
            aliens.AddAlien(ozzy, 1);
            aliens.AddAlien(python, 2);
            aliens.AddAlien(rattle, 3);
            aliens.AddAlien(marshall, 4);
            aliens.AddAlien(oscar, 5);

            //Display aliens
            aliens.DisplayAliens();

            //Calculate how much damage the aliens make 
            Console.WriteLine("\nDamage done by aliens: " + aliens.CalculateDamage());

            Console.ReadLine();
        }
    }
}
