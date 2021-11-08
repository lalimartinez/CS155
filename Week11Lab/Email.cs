/// Chapter No. 9		Lab No. 1
/// File Name: Email.cs
/// @author: Zitlali Martinez
/// Date:  November 07, 2021
///
/// Problem Statement: Write an Email class that stores the information of an email.
/// 
/// 
/// Overall Plan:
/// 1) Write a constructor for the instance variables
/// 2) Write the getters and setters using properties
/// 3) Override the ToString method to display the email information
///
using System;
using System.Collections.Generic;
using System.Text;

namespace Week11Lab
{
    class Email : Document
    {
        private string recipient;
        private string sender;
        private string title;

        //Constructor
        public Email(string recipient, string sender, string title, string text)
        {
            SetText(text);
            this.recipient = recipient;
            this.sender = sender;
            this.title = title;
        }

        //Getters and Setters
        public string Recipient { get => recipient; set => recipient = value; }
        public string Sender { get => sender; set => sender = value; }
        public string Title { get => title; set => title = value; }

        //ToString method 
        public override string ToString()
        {
            return "Email"
            + "\nRecipient: " + recipient
            + "\nSender: " + sender
            + "\nTitle: " + title
            + "\nBody:\n" + GetText();
        }
    }
}
