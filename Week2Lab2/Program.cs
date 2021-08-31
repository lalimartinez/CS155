/// Chapter No. 2		Lab No. 2
/// File Name: CandyCalculator.cs
/// @author: Zitlali Martinez
/// Date:  August 30, 2020
///
/// Problem Statement: Calculate the number of candy bars and gumballs a certain
/// number of coupons can get as well as the leftover coupons.
/// 
/// 
/// Overall Plan:
/// 1) Declare the number of coupons
/// 2) Declare variables to store the calculations
/// 3) Calculate the number of candy bars that the coupons can buy
/// 4) Calculate the leftover coupons after buying the candy bars
/// 5) Calculate the number of gumballs that can be bought with the leftover coupons
/// 6) Calculate the leftover coupons after buying the gumballs
/// 7) Print the number of candy bars and gumballs that can be bought and the leftover coupons
///
using System;

namespace Week2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_coupons = 108;
            int num_coupons_after_candyBars, num_coupons_after_gumBalls, num_candyBars, num_gumBalls;

            //integer division discards any remainder
            num_candyBars = num_coupons / 10;
            //calculate remaining coupons
            num_coupons_after_candyBars = num_coupons % 10;

            //calculate gumballs
            num_gumBalls = num_coupons_after_candyBars / 3;

            //calculate any leftover coupons
            num_coupons_after_gumBalls = num_coupons_after_candyBars % 3;

            Console.WriteLine("Your {0} coupons can be redeemed for {1} candy bars and {2} gumballs with {3} coupons leftover.", num_coupons, num_candyBars, num_gumBalls, num_coupons_after_gumBalls);

            Console.ReadLine();
        }
    }
}
