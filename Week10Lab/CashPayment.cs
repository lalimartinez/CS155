/// Chapter No. 8		Lab No. 1
/// File Name: Payment.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a CashPayment class that extends the Payment class.
/// 
/// 
/// Overall Plan:
/// 1) Write a constructor that sets the amount of the payment
/// 2) Override the method that displays the payment amount so it includes that a cash
///    payment was made.
///

using System;
using System.Collections.Generic;
using System.Text;

namespace Week10Lab
{
    class CashPayment : Payment
    {
        //Constructor
        public CashPayment(double amount)
        {
            Amount = amount;
        }

        //Overridden method that displays payment
        public new void PaymentDetails()
        {
            Console.WriteLine("Amount of cash payment: $" + string.Format("{0:0.00}", Amount));
        }
    }
}
