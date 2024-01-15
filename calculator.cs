﻿using System.ComponentModel.DataAnnotations;

namespace Calculator
{
    internal class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;

            Console.WriteLine("Welcome to the calculator program!\n");
            Console.WriteLine("Enter your first number: ");

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Great!\nNow enter your second number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of equation are you looking to do?\n");
            Console.WriteLine("Enter 'a' for addition, 's' for subtraction, 'm' for multiplication, or 'd' for division: ");

             answer = Console.ReadLine(); 
            
            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s") 
            {
                result = num1 - num2;
            }
            else if (answer == "m") 
            {
                result = num1 * num2;
            }
            else 
            {
                result = num1 / num2;
            }

            Console.WriteLine("....\nThe result is " + result);
            Console.WriteLine("Thank you for using the Calculator program!\nGoodbye!");

            Console.ReadKey();
        }
    }
}
