/// Chapter No. 6		Exercise No. 1
/// File Name: Counter.cs
/// @author: Zitlali Martinez
/// Date:  October 10, 2021
///
/// Problem Statement: Write a counter class that creates a counter object to count things.
/// 
/// Overall Plan:
/// 1) Write method to set counter to zero
/// 2) Write method to increase count by one
/// 3) Write method to decrease count by one as long as the count is greater than zero
/// 4) Write a getter method that return the count
/// 5) Write method that outputs the current count of the object
/// 6) Override the ToString method to display the counter object
/// 7) Override the Equals method to compare two counter objects
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek7Part1
{
    class Counter
    {
        private int count;

        //Set counter to 0
        public void setCount()
        {
            count = 0;
        }

        //Increase count by one
        public void increaseCount()
        {
            count++;
        }

        //Decrease count by one
        public void decreaseCount()
        {
            //Only decrease count if it is greater than 0
            if (count > 0)
                count--;
            else
                Console.WriteLine("Counter cannot go negative.");
        }

        //Getter method to get the count
        public int getCount()
        {
            return count;
        }

        //Method to output count to string
        public void currentCount()
        {
            Console.WriteLine("The current count is " + count);
        }

        //ToString method
        public override string ToString()
        {
            return "Count: " + count;
        }

        //Equals method
        public override bool Equals(Object other)
        {
            if (other == null)
                return false;
            if (!(other is Counter))
                return false;

            Counter o = (Counter)other;
            return this.count == o.count;
        }
    }
}
