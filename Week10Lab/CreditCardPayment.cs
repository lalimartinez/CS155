/// Chapter No. 8		Lab No. 1
/// File Name: Payment.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a CreditCardPayment class that extends the Payment class and
/// also stores the card information.
/// 
/// 
/// Overall Plan:
/// 1) Write a constructor for all the instance variables and that sets the payment amount
/// 2) Write the getters and setters using properties
/// 3) Override the method that displays the payment so that it also displays the card information
///

using System;
using System.Collections.Generic;
using System.Text;

namespace Week10Lab
{
    class CreditCardPayment : Payment
    {
        private string name;
        private long cardNumber;

        //Constructor
        public CreditCardPayment(double amount, string _name, long _cardNumber)
        {
            Amount = amount;
            name = _name;
            cardNumber = _cardNumber;
        }

        //Getter and setter for instance variables 
        public string Name { get => name; set => name = value; }
        public long CardNumber { get => cardNumber; set => cardNumber = value; }

        //Overridden method that displays payment
        public new void PaymentDetails()
        {
            Console.WriteLine("Name on card: " + name);
            Console.WriteLine("Card Number: " + cardNumber);
            Console.WriteLine("Amount of credit card payment: $" + string.Format("{0:0.00}", Amount));
        }
    }
}
