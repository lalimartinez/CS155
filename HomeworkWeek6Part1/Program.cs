/// Chapter No. 5		Exercise No. 1
/// File Name: CopyArray.cs
/// @author: Zitlali Martinez
/// Date:  October 03, 2021
///
/// Problem Statement: Fill an array with ten numbers. Then create a second array and copy the 
/// values of the first array into the second array. Print both arrays to the screen.
/// 
/// Overall Plan:
/// 1) Create an array to hold ten values and fill the array 
/// 2) Create a second array the same length of the first
/// 3) Use a for loop to fill the second array with the same values as the first array
/// 4) Print both arrays to the screen
/// 
using System;

namespace HomeworkWeek6Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create first array
            int[] numbers = new int[10];
            //Fill first array
            for (int i = 0; i < 10; i++)
                numbers[i] = i * 5;

            //Create copy array
            int[] copyArray = new int[numbers.Length];
            //Fill copy array with numbers in first array
            for (int i = 0; i < numbers.Length; i++)
                copyArray[i] = numbers[i];

            //Print both arrays to the scree
            Console.WriteLine("First Array:");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine("\nCopy Array:");
            for (int i = 0; i < copyArray.Length; i++)
                Console.Write(copyArray[i] + " ");

            Console.ReadLine();

        }
    }
}
