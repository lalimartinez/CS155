/// Chapter No. 8		Lab No. 1
/// File Name: PaymentDriver.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a driver program to test the classes derived from the Payment class and the methods.
/// 
/// 
/// Overall Plan:
/// 1) Create two cash payment objects
/// 2) Create two card payment classes
/// 3) Use the PaymentDetails method to display the details of the payment for each object
///

using System;

namespace Week10Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two cash payments 
            CashPayment cashA = new CashPayment(20);
            CashPayment cashB = new CashPayment(45.67);

            //Create two card payments 
            CreditCardPayment cardA = new CreditCardPayment(34.50, "Lali Martinez", 456729476756);
            CreditCardPayment cardB = new CreditCardPayment(54, "Evan Sanchez", 728954376109);

            //Display the payment information for each object using PaymentDetails method 
            cashA.PaymentDetails();
            Console.WriteLine();

            cashB.PaymentDetails();
            Console.WriteLine();

            cardA.PaymentDetails();
            Console.WriteLine();

            cardB.PaymentDetails();

            Console.ReadLine();
        }
    }
}
