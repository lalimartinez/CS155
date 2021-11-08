/// Chapter No. 9		Exercise No. 1
/// File Name: Person.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a Person class that stores a person's name.
/// 
/// Overall Plan:
/// 1) Write 3 constructors: One no argument constructor, one for the instance variable, and one that takes in another Person object.
/// 2) Write a get method and a set method
/// 3) Override the ToString method to display the object
/// 4) Override the Equals method to compare two objects
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek11
{
    class Person
    {
        private string name;

        //Empty constructor
        public Person() { }

        //Constructor for instance variable
        public Person(string theName)
        {
            name = theName;
        }

        //Constructor using another person object 
        public Person(Person obj)
        {
            name = obj.name;
        }

        //Getter and setter 
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        //ToString method 
        public override string ToString()
        {
            return "Person's name: " + name;
        }

        //Equals method 
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;

            Person other = (Person)obj;
            return this.name == other.name;
        }
    }
}
