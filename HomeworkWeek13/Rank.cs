/// Chapter No. 11		Exercise No. 1
/// File Name: Rank.cs
/// @author: Zitlali Martinez
/// Date:  November 20, 2021
///
/// Problem Statement: Write a Rank class that stores the rank of the name and how many times it was used.
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Write the getters and setters using properties
/// 3) Override the ToString method to display the Rank object
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkWeek13
{
    class Rank
    {
        private int rankNum;
        private int count;

        //Constructor 
        public Rank(int rankNum, int count)
        {
            this.rankNum = rankNum;
            this.count = count;
        }

        //Getters and Setters
        public int RankNum { get => rankNum; set => rankNum = value; }
        public int Count { get => count; set => count = value; }

        //ToString method 
        public override string ToString()
        {
            return "Rank: " + rankNum +
            "\nNumber of names: " + count;
        }
    }
}
