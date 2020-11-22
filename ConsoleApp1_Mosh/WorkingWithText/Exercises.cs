using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.WorkingWithText
{
    class Exercises
    {
        public static void main(string[] args) 
        {

            Prob6();

        }

        public static void prob1()
        {

            // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive. 
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter few numbers seperated by '-' ");
            var arr = Console.ReadLine().Split('-');
            var numlis = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                numlis.Add(Convert.ToInt32(arr[i]));
            }
            numlis.Sort();
            var iterator = 0;

            while (iterator < numlis.Count - 1)
            {
               
                if (numlis[iterator] + 1 == (numlis[iterator + 1]))
                {
                    if (iterator == numlis.Count - 2)
                    {
                        Console.WriteLine("Concecutive");
                        break;
                    }
                }
                else if (iterator == numlis.Count - 2)
                {
                    Console.WriteLine("Not Concecutive");
                }
                iterator++;
            }

        }

        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
        //check to see if there are duplicates.If so, display "Duplicate" on the console.


        static void Prob2()
        {
            Console.WriteLine("Enter few numbers seperated by '-' ");
            var arr = Console.ReadLine().Split('-');
            var numlis = new List<int>();

            try
            {
                if (arr.Length == 0)
                {
                    Console.WriteLine("Program Exited");
                    return;
                }

                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        numlis.Add(Convert.ToInt32(arr[i]));
                    }
                    var uniques = new List<int>();
                    var includesDuplicates = false;
                    foreach (var number in numlis)
                    {
                        if (!uniques.Contains(number))
                            uniques.Add(number);
                        else
                        {
                            includesDuplicates = true;
                            break;
                        }
                    }

                    if (includesDuplicates)
                        Console.WriteLine("Duplicate");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input - Program Exit");
            }
        }


        //3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        //If the user doesn't provide any values, consider it as invalid time.
        static void Prob3()
        {
           // var obj = new DateTime();
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00) :");
            try
            {
                var val = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ok");
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid Time");
            }
        }

        //4- Write a program and ask the user to enter a few words separated by a space. 
        //Use the words to create a variable name with PascalCase. 
        //For example, if the user types: "number of students", display "NumberOfStudents". 
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".


        static void Prob5() {

            Console.WriteLine("Enter a few words separated by a space.");
            var wordsArr = Console.ReadLine().Trim().Split(" ");
            var res = "";

            foreach (var item in wordsArr)  
            {
                res += char.ToUpper(item[0]) + item.Substring(1).ToLower(); //Starting from cahr position 1 until the end
            }
            Console.WriteLine(res);
        }


        //5- Write a program and ask the user to enter an English word. 
        //Count the number of vowels (a, e, o, u, i) in the word. 
        //So, if the user enters "inadequate", the program should display 6 on the console.

        static void Prob6() {

            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine().Trim().ToLower();
            var vowlis = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var counter = 0;
            foreach (var item in input)
            {
                if (vowlis.Contains(item))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

    }
}
