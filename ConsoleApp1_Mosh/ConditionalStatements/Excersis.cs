using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class Excersis
    {

        //1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
        //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values entered into input boxes need to be validated.)


        public static void prob1() {

            //Enter a Number
            Console.WriteLine("Enter a number b/w 1 - 10 : ");

            try
            {
                var input = Console.ReadLine();
                Console.WriteLine(input.GetType());
                Console.WriteLine(input);
                int val = Int32.Parse(input);

                // float price = (isGoldCustomer) ? 19.95f : 29.95f;
                if (val >= 1 && val <= 10)
                {
                    Console.WriteLine("Valid");
                }

                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            
        }


        public static void prob2() {

            // Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.ReadLine();


        }
        public static void Main(string[] args) {

            prob1();


        }
    }
}
