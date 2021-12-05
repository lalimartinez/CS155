﻿/// Chapter No. 12		Lab No. 1
/// File Name: Rectangle.cs
/// @author: Zitlali Martinez
/// Date:  December 05, 2021
///
/// Problem Statement: Write a program that uses 2 methods via a delegate.
/// 
/// 
/// Overall Plan:
/// 1) Create an area method that displays the area of a rectangle.
/// 2) Create a perimeter method that displays the perimeter of a rectangle.
/// 3) Declare a delegate for the rectangle that takes in the height and width.
/// 4) Create a rectangle object
/// 5) Create a delegate object and pass in the area method
/// 6) Call the perimeter method and add it to the delegate object
/// 7) Use the invoke method to pass values into the delegate object
/// 
using System;

namespace Week14Lab
{
    class rectangle
    {
        static void Main(string[] args)
        {
            //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. 
            //Delegates in C# are similar to the function pointer in C/C++. 
            //It provides a way which tells which method is to be called when an event is triggered.
            // 
            // creating object of class  
            // "rectangle", named as "rect" 
            rectangle rect = new rectangle();

            // these two lines are normal calling 
            // of that two methods 
            // rect.area(6.3, 4.2); 
            // rect.perimeter(6.3, 4.2); 

            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            rectDelegate rectdele = new rectDelegate(rect.area);

            // also can be written as  
            // rectDelegate rectdele = rect.area; 

            // call 2nd method "perimeter" 
            // Multicasting 
            //rectdele += rect.perimeter;
            rectdele = rectdele + new rectDelegate(rect.perimeter);

            // pass the values in two method  
            // by using "Invoke" method 
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // call the methods with  
            // different values 
            rectdele.Invoke(16.3, 10.3);
        }

        // declaring delegate 
        public delegate void rectDelegate(double height, double width);

        //"area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        //"perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
}
