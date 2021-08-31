using System;

namespace Week2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you, multiply them, and divide the product and sum.");
            Console.WriteLine("Enter one number and press enter, enter second number and press enter, enter third number and press enter:");

            // declare two integer variables
            int n1, n2, n3, sum, product; 
            double division;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            division = product / (double)sum;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of the three numbers is: " + sum);
            Console.WriteLine("The product of the three numbers is: " + product);
            Console.WriteLine("The division of the sum and product is: " + division);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
