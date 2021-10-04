/// Chapter No. 5		Lab No. 1
/// File Name: GuessingGame.cs
/// @author: Zitlali Martinez
/// Date:  October 02, 2021
///
/// Problem Statement: Ask user to guess a number. Tell the user if the correct number is lower or
/// higher than their guess. When user guesses the correct number, tell them how many guesses it took.
/// 
/// 
/// Overall Plan:
/// 1) Generate a random number
/// 2) Use a loop to keep asking user for a number while the guess is incorrect
/// 3) Increase the number of guesses by one
/// 4) If number is lower than the guess, let user know
/// 5) Else if number is higher than the guess, let user know
/// 6) Else, break out of the loop
/// 7) Print how many guesses it took the user to get the correct number
///
using System;

namespace Week6Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate a random number between 0 and 100
            Random generator = new Random();
            int r = generator.Next(101);
            int guess, count = 0;

            //Use a do-while loop to keep asking user to guess a number while their guess isn't correct
            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                guess = Int32.Parse(Console.ReadLine());

                //Increase the guess count by one
                count++;

                //Tell user if guess is lower or higher than the number
                if (r < guess)
                    Console.WriteLine("The correct number is lower than your guess.");
                else if (r > guess)
                    Console.WriteLine("The correct number is higher than your guess.");
                else
                    break;
            } while (guess != r);

            //Tell user how many guesses it took them to guess the correct number
            Console.WriteLine("You guessed the correct number! It took you " + count + " guesses.");
            Console.ReadLine();
        }
    }
}
