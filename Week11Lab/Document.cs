/// Chapter No. 9		Lab No. 1
/// File Name: Document.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write a Document class that stores the text of a document.
/// 
/// 
/// Overall Plan:
/// 1) Write 2 constructors: one no argument one and one that takes in the text.
/// 2) Write a getter method 
/// 3) Write a setter method
/// 4) Override the ToString method to display the document text
///
using System;
using System.Collections.Generic;
using System.Text;

namespace Week11Lab
{
    class Document
    {
        private string text;

        //Empty constructor 
        public Document() { }

        //Overloaded constructor
        public Document(string _text)
        {
            text = _text;
        }

        //Getter and setter 
        public string GetText()
        {
            return text;
        }

        public void SetText(string _text)
        {
            text = _text;
        }

        //ToString method 
        public override string ToString()
        {
            return "Document text:\n" + text;
        }
    }
}
