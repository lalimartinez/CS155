/// Chapter No. 5		Exercise No. 2
/// File Name: ReverseArray.cs
/// @author: Zitlali Martinez
/// Date:  October 03, 2021
///
/// Problem Statement: Create a method to generate an array, a method to print an array, and 
/// a method to reverse the array. Use the methods to reverse an array and print it.
/// 
/// Overall Plan:
/// 1) Create a method that returns an array filled with ten values 
/// 2) Create a method that takes in an array and prints it to the screen
/// 3) Create a method that takes in an array, reverses it, and returns the reversed array
/// 4) Create an array and use the method that generates an array to fill it
/// 5) Send the array into the reverse method
/// 6) Send the array into the method that prints it to the screen
/// 
using System;

namespace HomeworkWeek6Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.ReadLine();
        }

        //Method to generate an array of numbers
        static int[] GenerateNumbers()
        {
            //Declare array
            int[] nums = new int[10];
            //Fill array
            for (int i = 0; i < 10; i++)
                nums[i] = i;
            //Return array
            return nums;
        }

        //Method to print array of numbers
        static void PrintNumbers(int[] nums)
        {
            foreach (int element in nums)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        //Method to revers the array
        static int[] Reverse(int[] nums)
        {
            int temp;
            //Use a loop to go through half the array and swap values starting with the first and last to reverse it
            for(int i = 0; i < nums.Length/2; i++)
            {
                temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }
            //Return array
            return nums;
        }
    }
}
