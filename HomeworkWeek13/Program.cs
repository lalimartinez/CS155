/// Chapter No. 11		Exercise No. 1
/// File Name: Names.cs
/// @author: Zitlali Martinez
/// Date:  November 20, 2021
///
/// Problem Statement: Write a program that reads in files with the most popular boy and girl names into a dictionary.
/// Have user enter a name and display where the name ranks and how many times it was used.
/// 
/// Overall Plan:
/// 1) Create a readFile method that reads a file into a dictionary 
///     a) While the current line is not null
///     b) Split the line at the space
///     c) Create a new Rank object
///     d) Add the name and Rank to the dictionary
/// 2) Create two dictionaries for the boy and girl names
/// 3) Read files into the dictionaries using the readFile method
/// 4) Prompt user to enter a name
/// 5) If the name is in the boy dictionary, display where it ranks and how many times it was used
/// 6) Else, display a message that the name isn't in the boy dictionary
/// 7) If the name is in the girl dictionary, display where it ranks and how many times it was used
/// 8) Else, display a message that the name isn't in the girl dictionary
/// 
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeworkWeek13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two dictionaries to hold names and rank
            Dictionary<string, Rank> boyNames = new Dictionary<string, Rank>();
            Dictionary<string, Rank> girlNames = new Dictionary<string, Rank>();

            //Read files into dictionaries
            readFile("C:\\Users\\marti\\Downloads\\boynames.txt", boyNames);
            readFile("C:\\Users\\marti\\Downloads\\girlnames.txt", girlNames);

            string name;

            //Ask user to enter a name 
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();
            //Check to see if name exists in boy dictionary 
            Console.WriteLine();
            if (boyNames.ContainsKey(name))
            {
                Console.WriteLine(name + " is ranked " + boyNames[name].RankNum + " in popularity among boys with " + boyNames[name].Count + " namings.");
            }
            else
                Console.WriteLine(name + " is not ranked among the top 1000 boy names.");

            //Check to see if name exists in girl dictionary 
            if (girlNames.ContainsKey(name))
            {
                Console.WriteLine(name + " is ranked " + girlNames[name].RankNum + " in popularity among girls with " + girlNames[name].Count + " namings.");
            }
            else
                Console.WriteLine(name + " is not ranked among the top 1000 girl names.");

            Console.ReadLine();
        }

        //Method to read a file into a dictionary
        public static void readFile(String fileName, Dictionary<string, Rank> d)
        {
            int rank = 0, count;
            Rank nameRank;
            using (StreamReader s = new StreamReader(fileName))
            {
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    //split line
                    string[] lineData = line.Split(' ');
                    //Increase rank by one and convert count to Int
                    rank++;
                    count = Int32.Parse(lineData[1]);
                    //Create new object with rank and count
                    nameRank = new Rank(rank, count);
                    //Add name dictionary
                    d.Add(lineData[0], nameRank);
                }
            }
        }
    }
}
