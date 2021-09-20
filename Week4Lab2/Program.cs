/// Chapter No. 3		Lab No. 2
/// File Name: FixLamp.cs
/// @author: Zitlali Martinez
/// Date:  September 19, 2021
///
/// Problem Statement: Help user figure out how to fix a lamp.
/// 
/// 
/// Overall Plan:
/// 1) Print welcome message
/// 2) Ask user if the lamp is plugged in
/// 3) If lamp is not plugged in, tell user to plug it in
/// 4) Else, ask user if the bulb is burned out
/// 5) If the bulb is burned out, tell user to replace the bulb
/// 6) Else, tell user to repair the lamp
///
using System;

namespace Week4Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string answer;

            Console.WriteLine("I can help fix your lamp.");
            //Ask user if lamp is plugged in
            Console.WriteLine("Is the lamp plugged in? (yes/no)");
            answer = Console.ReadLine();
            answer = answer.ToLower();
            //If answer is no have user plug in lamp, else move on
            if(answer == "no")
                Console.WriteLine("Plug in the lamp.");
            else
            {
                //Ask user if bulb is burned out
                Console.WriteLine("Is the bulb burned out? (yes/no)");
                answer = Console.ReadLine().ToLower();
                //If answer is yes have user replace bulb, else repair lamp
                if (answer == "yes")
                    Console.WriteLine("Replace the bulb.");
                else
                    Console.WriteLine("Repair the lamp.");
            }

            Console.ReadLine();
            
        }
    }
}
