/// Chapter No. 8		Lab No. 1
/// File Name: Payment.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a Payment class that stores the amount of a payment.
/// 
/// 
/// Overall Plan:
/// 1) Write the getter and setter using properties
/// 2) Write a method that displays the payment amount
///

using System;
using System.Collections.Generic;
using System.Text;

namespace Week10Lab
{
    class Payment
    {
        private double amount;

        //Getter and setter 
        public double Amount { get => amount; set => amount = value; }

        //Method to output the payment 
        public void PaymentDetails()
        {
            Console.WriteLine("The amount of the payment is: $" + string.Format("{0:0.00}", amount));
        }
    }
}
