/// Chapter No. 9		Lab No. 1
/// File Name: DocumentDriver.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a driver program to create email and file objects. Send them into a method that checks if the objects contain a keyword.
/// 
/// 
/// Overall Plan:
/// 1) Write a method that takes in a document object and a keyword and checks if the document conatains the keyword
/// 2) Create two email objects
/// 3) Create two file objects
/// 4) Display the information of the objects to the screen
/// 5) Send the objects into the ContainsKeyword method and display whether or not each object contains the keyword
///
using System;

namespace Week11Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two emails
            Email email1 = new Email("recipient1@gmail.com", "imsending@gmail.com", "How's it going?", "Hello, just checking in. How are you? -Lali");
            Email email2 = new Email("someone@hotmail.com", "hello@hotmail.com", "Meeting", "Hello, Reminding you of the meeting scheduled tomorrow at 2pm. See you then! -Lali");

            //Create two files
            File file1 = new File("files/documents", "This is an example file.");
            File file2 = new File("files/desktop", "This is a very important file with very important information.");

            //Display the objects 
            Console.WriteLine(email1);
            Console.WriteLine("\n" + email2);
            Console.WriteLine("\n" + file1);
            Console.WriteLine("\n" + file2);

            //Send objects into method to see if they contain a keyword 
            Console.WriteLine();
            if (ContainsKeyword(email1, "hi"))
                Console.WriteLine("Email1 contains the keyword.");
            else
                Console.WriteLine("Email1 does not contain the keyword.");

            if (ContainsKeyword(email2, "Meeting"))
                Console.WriteLine("Email2 contains the keyword.");
            else
                Console.WriteLine("Email2 does not contain the keyword.");

            if (ContainsKeyword(file1, "example"))
                Console.WriteLine("File1 contains the keyword.");
            else
                Console.WriteLine("File1 does not contain the keyword.");

            if (ContainsKeyword(file2, "important"))
                Console.WriteLine("File2 contains the keyword.");
            else
                Console.WriteLine("File2 does not contain the keyword.");

            Console.ReadLine();
        }
        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
                return true;

            return false;
        }
    }
}
