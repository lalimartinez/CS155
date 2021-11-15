/// Chapter No. 10		Lab No. 1
/// File Name: PhoneBook.cs
/// @author: Zitlali Martinez
/// Date:  November 14, 2021
///
/// Problem Statement: Write a program that stores phone numbers. The user should be able to add, remove, and lookup a phone number.
/// 
/// 
/// Overall Plan:
/// 1) Create a dictionary to store the name/phone number pair
/// 2) Create a menu that allows user to add a phone number, remove a phone number, view the phone book, lookup a phone number, ot exit the menu
/// 3) For choice 1: have user enter a new name and phone number to add to phone book
/// 4) For choice 2: Have user enter name of person they would like to remove from the phone book
/// 5) For choice 3: Display the entire phone book
/// 6) For choice 4: Have user enter name of peron whose phone number they would like to lookup
/// 7) For choice 5: Exit the menu
/// 8) As a defualt: display a message that choice must be between 1-5
/// 9) Keep displaying the menu as long as choice isn't 5
/// 
using System;
using System.Collections.Generic;

namespace Week12Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new dictionary to hold phone numbers
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int choice;
            string name, phoneNum;

            //Create menu for user in a do-while loop
            do
            {
                Console.WriteLine("Choose an option" +
                "\n1)Add a new phone number" +
                "\n2)Remove a phone number" +
                "\n3)View phone book" +
                "\n4)Lookup a phone numbrt" +
                "\n5) Exit" +
                "\nEnter a choice:");
                choice = Int32.Parse(Console.ReadLine());

                //switch choice 
                switch (choice)
                {
                    //Add a new phone nunber
                    case 1:
                        Console.WriteLine("\nEnter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter phone number:");
                        phoneNum = Console.ReadLine();
                        phoneBook.Add(name, phoneNum);
                        break;

                    //Remove a phone number
                    case 2:
                        Console.WriteLine("\nEnter name of person to be removed from phone book:");
                        name = Console.ReadLine();
                        if (phoneBook.ContainsKey(name))
                            phoneBook.Remove(name);
                        else
                            Console.WriteLine("Name not found.");
                        break;

                    //View phone book
                    case 3:
                        Console.WriteLine();
                        foreach (KeyValuePair<string, string> p in phoneBook)
                            Console.WriteLine(p.Key + ": " + p.Value);
                        break;

                    //Lookup a phone number
                    case 4:
                        Console.WriteLine("\nEnter name of person's phone number to look up:");
                        name = Console.ReadLine();
                        if (phoneBook.ContainsKey(name))
                            Console.WriteLine("Phone Number: " + phoneBook[name]);
                        else
                            Console.WriteLine("Name not found.");
                        break;

                    //Exit
                    case 5:
                        Console.WriteLine("\nExiting Menu");
                        break;

                    //If choice entered isn't 1-5
                    default:
                        Console.WriteLine("\nChoice must be between 1-5");
                        break;
                }
                Console.WriteLine();
            } while (choice != 5);

            Console.ReadLine();
        }
    }
}
