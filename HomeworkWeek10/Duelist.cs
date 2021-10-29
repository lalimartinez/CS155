/// Chapter No. 8		Exercise No. 1
/// File Name: Duelist.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a Duelist class that stores the information for an individual duelist and lets them shoot at another duelist.
/// 
/// Overall Plan:
/// 1) Write a constructor that takes in the name and shooting accuracy of the duelist and sets their alive status to true
/// 2) Write the getters and setters using properties
/// 3) Write a method that lets the duelist shoot at another duelist and sets the alive status of the other duelist to false 
///    if the duelist shoots them
/// 

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek10
{
    class Duelist
    {
        private string name;
        private double shootingAccuracy;
        private bool alive;

        //Random number generator 
        Random generator = new Random();

        //Constructor
        public Duelist(string _name, double _shootingAccuracy)
        {
            name = _name;
            shootingAccuracy = _shootingAccuracy;
            alive = true;
        }

        //Getters and setters 
        public string Name { get => name; set => name = value; }
        public double ShootingAccuracy { get => shootingAccuracy; set => shootingAccuracy = value; }
        public bool Alive { get => alive; set => alive = value; }

        //Method to shoot at target 
        public void ShootAtTarget(Duelist target)
        {
            //Generate random number between 0 and 100
            double r = generator.NextDouble();
            //Console.WriteLine(r);
            if (r < shootingAccuracy)
                target.Alive = false;
        }
    }
}
