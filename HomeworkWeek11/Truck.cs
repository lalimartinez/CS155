/// Chapter No. 9		Exercise No. 1
/// File Name: Truck.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a Truck class derived from the Vehicle class that holds information about a truck.
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Write the getters and setters using properties
/// 3) Override the ToString() method to display the object
/// 4) Override the Equals method to compare two objects
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek11
{
    class Truck : Vehicle 
    {
        private double loadCapacity;
        private int towCapacity;

        //Constructor
        public Truck(Manufacturer name, int _cylinders, Person _owner, double _loadCapacity, int _towCapacity)
        {
            Name = name;
            Cylinders = _cylinders;
            Owner = _owner;
            loadCapacity = _loadCapacity;
            towCapacity = _towCapacity;
        }

        //Getters and setters 
        public double LoadCapacity { get => loadCapacity; set => loadCapacity = value; }
        public int TowCapacity { get => towCapacity; set => towCapacity = value; }

        //ToString method
        public override string ToString()
        {
            return "~~~Truck Info~~~"
            + "\nManufacturer: " + Name
            + "\nCylinders: " + Cylinders
            + "\nOwner: " + Owner.GetName()
            + "\nLoad Capacity (tons): " + loadCapacity
            + "\nTow Capacity (pounds): " + towCapacity;
        }

        //Equals method 
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Truck))
                return false;
            Truck o = (Truck)obj;
            return this.Name == o.Name && this.Cylinders == o.Cylinders && this.Owner == o.Owner && this.loadCapacity == o.loadCapacity && this.towCapacity == o.towCapacity;
        }
    }
}
