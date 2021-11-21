/// Chapter No. 11		Lab No. 1
/// File Name: Parameters.cs
/// @author: Zitlali Martinez
/// Date:  November 20, 2021
///
/// Problem Statement: Write a program to test optional parameters, named parameters, and a variable number of parameters.
/// 
/// 
/// Overall Plan:
/// 1) Create a method to multiply two numbers that sets the defualt value of the parameters to zero
/// 2) Create a method that averages two numbers
/// 3) Create a method that sums up the numbers sent it
/// 4) Use the multiply method to test optional parameters by sending in two numbers and then not sending in any numbers
/// 5) Use the average method to test named parameters
/// 6) Use the sum method to test a variable number of parameters by sending in 3 numbers then 5 numbers
/// 7) Print results to the screen
/// 
using System;

namespace Week13Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test optional parameters 
            Console.WriteLine("5 * 6 = " + Multiply(5, 6));
            Console.WriteLine("0 * 0 = " + Multiply());

            //Test named parameters 
            Console.WriteLine("\nThe average if 56 and 67 is " + Average(a: 56, b: 67));

            //Test number of parameters 
            Console.WriteLine("\nThe sum of 1-3 is " + Sum(1, 2, 3));
            Console.WriteLine("The sume of 1-5 is " + Sum(1, 2, 3, 4, 5));

            Console.ReadLine();
        }

        //Method that uses optional parameters 
        //Takes to two numbers and multiplies them, default value of the two numbers is 0
        public static int Multiply(int a = 0, int b = 0)
        {
            return a * b;
        }

        //Method for named parameters 
        //Takes two numbers and averages them
        public static double Average(double a, double b)
        {
            return (a + b) / 2.0;
        }

        //Method for variable number of parameters
        //Adds the numbers passed in 
        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
                total += num;
            return total;
        }
    }
}
