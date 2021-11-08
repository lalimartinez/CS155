/// Chapter No. 9		Lab No. 1
/// File Name: Email.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a File class that stores the information of a file.
/// 
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Write the getters and setters using properties
/// 3) Override the ToString method to display the file information
///
using System;
using System.Collections.Generic;
using System.Text;

namespace Week11Lab
{
    class File : Document
    {
        private string pathname;

        //Constructor
        public File(string pathname, string text)
        {
            SetText(text);
            this.pathname = pathname;
        }

        //ToString method
        public override string ToString()
        {
            return "File"
            + "\nPathname: " + pathname
            + "\nText:\n" + GetText();
        }
    }
}
