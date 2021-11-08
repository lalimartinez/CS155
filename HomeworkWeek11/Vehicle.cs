/// Chapter No. 9		Exercise No. 1
/// File Name: Vehicle.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write an enum to hold manufacturers. Write a Vehicle class that holds information about a vehicle.
/// 
/// Overall Plan:
/// 1) Write a Manufacturer enum that holds the names of manufacturers
/// 2) Write 2 constructors: one no argument constructor and one for the instance variables
/// 3) Write the getters and setters using properties
/// 4) Override the ToString() method to display the object
/// 5) Override the Equals method to compare two objects
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek11
{
    //Enum for manufacturer
    public enum Manufacturer {
      Toyota,
      Honda,
      Ford,
      BMW,
      Hyundai,
      Volkswagon,
      Audi,
      Chevrolet
    }

    class Vehicle
    {
        private Manufacturer name;
        private int cylinders;
        private Person owner;

        //No argument constructor 
        public Vehicle() { }

        //Constructor 
        public Vehicle(Manufacturer _name, int _cylinders, Person _owner)
        {
            name = _name;
            cylinders = _cylinders;
            owner = _owner;
        }

        //Getters and setters
        public Manufacturer Name { get => name; set => name = value; }
        public int Cylinders { get => cylinders; set => cylinders = value; }
        public Person Owner { get => owner; set => owner = value; }

        //ToString method 
        public override string ToString()
        {
            return "~~~Vehicle Info~~~"
            + "\nManufacturer: " + name
            + "\nCylinders: " + cylinders
            + "\nOwner: " + owner.GetName();
        }

        //Equals method 
        public override bool Equals(Object other)
        {
            if (other == null)
                return false;
            if (!(other is Vehicle))
                return false;
            Vehicle o = (Vehicle)other;
            return this.name == o.name && this.cylinders == o.cylinders && this.owner == o.owner;
        }
     }
 }
