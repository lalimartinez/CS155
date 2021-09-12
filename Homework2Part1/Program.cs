/// Chapter No. 2		Exercise No. 1
/// File Name: PigLatin.cs
/// @author: Zitlali Martinez
/// Date:  September 12, 2021
///
/// Problem Statement: Create variables to hold first name and last name. Then create
/// a variable to hold the name in pig latin.
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Declare variables to hold the first name and last name
/// 3) Declare a variable to hold the pig latin name
/// 4) Convert name to pig latin and assign it to the pig latin name
/// 5) Print pig latin name to the screen
///
using System;

namespace Homework2Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("This program displays a name in pig latin.");
            
            //Declare variables to hold first name and last name
            String firstName = "Lali";
            String lastName = "Martinez";

            //Declare varibale to hold pig latin name
            String pigLatinName;
            pigLatinName = firstName.Substring(1,1).ToUpper() + firstName.Substring(2) + 
                firstName.Substring(0, 1).ToLower() + "ay " + lastName.Substring(1,1).ToUpper() +
                lastName.Substring(2) + lastName.Substring(0, 1).ToLower() + "ay";

            //Print pig latin name
            Console.WriteLine(pigLatinName);

            Console.ReadLine();
        }
    }
}
