using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.LoopingStatements
{
    class ExcerciseTwo
    {
        public static void main(string[] args) {


            test();


        }


        //1- Write a program to count how many numbers between 1 and 100 
        //are divisible by 3 with no remainder. Display the count on the console.

        static void prob1() {
            var i = 1;
            var counter = 0;
            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    //Console.WriteLine(i);
                    counter++;
                }
                i++;
            }
            Console.WriteLine("count :" + counter);
        }



        //2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.

        static void prob2() {

            var input = "";
            var sum = 0;
            while (input != "ok")
            {
                Console.WriteLine("Please Enter a number or OK to exit : ");
                input = Console.ReadLine();

                try
                {
                    sum += Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Program exited");
                    break;
                }
                
            }
            if (sum != 0)
            {
                Console.WriteLine("Sum of all the previously entered numbers : " + sum);
            }
            
        }

        //3- Write a program and ask the user to enter a number. 
        //Compute the factorial of the number and print it on the console. 
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


        static void Prob3() {

            var res = 1;
            Console.WriteLine("please enter a number: ");
            
            try
            {
                var input = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= input; i++)
                {
                    res *= i;

                }
                Console.WriteLine(res); 
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input");
            }
           
        }

        //5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum 
        //of the numbers and display it on the console. For example, 
        //if the user enters “5, 3, 8, 1, 4", the program should display 8.


        static void Prob5() {

            Console.WriteLine("Enter a serise of numbers seperated by ',' : ");
            string input = Console.ReadLine();
            string[] strings = input.Split(',');
            int[] ints = Array.ConvertAll(strings, s => int.Parse(s));
           // int[] newd = Array.Clear(ints, ints.Length, ints.Length);
            var greatestnum = 0;
            var maxNum = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > maxNum)
                {
                    greatestnum = ints[i];
                }
                else
                {
                    greatestnum = maxNum;
                }

            }
            Console.WriteLine(greatestnum);
           // int[] ints = Array.ConvertAll(strings, s => int.Parse(s));
           
        }


        static void test() {
            int a = 10;
            int b = 12;
            if (a > b)
            {

                return;
            }

            else {

                Console.WriteLine("else");
            }
        
        }


        //4- Write a program that picks a random number between 1 and 10. 
        //Give the user 4 chances to guess the number. 
        //If the user guesses the number, display “You won"; otherwise, display “You lost".
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)


        static void Prob4() {

            var random = new Random();
            var num = random.Next(1, 10);
            var counter = 1;

            
            Console.WriteLine(num);
            Console.WriteLine("Please Enter a number: ");
            var guess = Convert.ToInt32(Console.ReadLine());
            if (guess == num)
            {
                Console.WriteLine("You Won");
            }

            else
            {
                while (guess != num && counter <= 4)
                {
                    
                    Console.WriteLine("Nope ! Next guess pls " + "Chance no: " + counter + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == num)
                    {
                        Console.WriteLine("You Won");
                        break;
                    }
                    else if (counter == 4)
                    {
                        Console.WriteLine("You Loose");
                    }
                    counter++;
                   
                }
            }
        }
    }
}
