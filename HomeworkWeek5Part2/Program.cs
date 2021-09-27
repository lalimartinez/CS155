/// Chapter No. 4		Exercise No. 2
/// File Name: CoinToss.cs
/// @author: Zitlali Martinez
/// Date:  September 26, 2021
///
/// Problem Statement: Ask user to enter heads or tails for each coin toss. 
/// Display the total number and percentages of heads and tails tossed.
/// 
/// Overall Plan:
/// 1) Prompt user to enter to enter 'h' for heads or 't' for tails 
/// 2) Use a for loop to ask user for heads or tails eight times
/// 3) If user enters 'h', increase the number of heads, else increase the number of tails
/// 4) Calculate the percentage of heads and tails
/// 5) Print how many heads and tails there were and the percentage of each to the screen
/// 
using System;

namespace HomeworkWeek5Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create array to hold number of toss
            string[] toss = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth" };
            //Create variables to hold counts
            int headCount = 0, tailCount = 0;
            string headsOrTails;
            double headPercent, tailPercent;

            Console.WriteLine("For each coin toss enter 'h' for heads or 't' for tails.");

            //Use for loop to go through coin tosses
            for(int i = 0; i < 8; i++)
            {
                Console.Write(toss[i] + " toss: ");
                headsOrTails = Console.ReadLine();
                //If h increase head count, else increase tail count
                if (headsOrTails == "h")
                    headCount++;
                else
                    tailCount++;
            }

            //Calculate percentages
            headPercent = ((double)headCount / 8) * 100;
            tailPercent = ((double)tailCount / 8) * 100;

            //Display results
            Console.WriteLine("Number of heads: " + headCount);
            Console.WriteLine("Number of tails: " + tailCount);
            Console.WriteLine("Percent heads: " + headPercent);
            Console.WriteLine("Percent tails: " + tailPercent);

            Console.ReadLine();
        }
    }
}
