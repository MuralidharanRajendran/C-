using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.ArraysAndList
{
    class Excersise
    {
        //ctrl + w  -> To select a loop;

        public static void main(string[] args) {

            //Prob2("Murali");
            Prob5();


        }

//1- When you post a message on Facebook, depending on the number of people who like your post, 
//Facebook displays different information.If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses 
//Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

        static void Prob1() 
        {

            // 1. Ask the user to enter different Name
            string name = null;
            var counter = -1;

            //Creating a list for
            var ppllis = new List<string>();
            while (name != "")
            {
                Console.WriteLine("Please enter a name : ");
                name = Console.ReadLine();

                //Add names to ppllis
                ppllis.Add(name);

                //Counter for number of names
                counter++;
            }

            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            if (counter == 1) {

                Console.WriteLine(string.Format("{0} likes you post.", ppllis[0]));
            }

            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            else if (counter == 2)
            {

                Console.WriteLine(string.Format("{0} and {1} likes you post.", ppllis[0],ppllis[1]));
            }

//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

            else
            {
                var others = Convert.ToString(ppllis.Count - 3);
                Console.WriteLine(ppllis[0] + ", " + ppllis[1] + " and " + others + " others like your post.");
            }

        }

        //2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the 
        //result in a new string. Display the reversed name on the console.


        static void Prob2(string toReverse) {

            // Write a program and ask the user to enter their name.
            var nameArr = toReverse.ToCharArray();
            Array.Reverse(nameArr);
           // return new String(nameArr);
            Console.WriteLine(new String(nameArr)); //This is converting the char array to string

//By calling ToString you just get the default implementation that every class inherits from object.
//.NET can't provide a special implementation just for an array of char; the override would have to apply to all types of array.
//Instead, you can pass the array to String's constructor, return new String(reversedString).
        }


        //3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message 
        //and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


        static void Prob3()
        {
            var i = 0;
            var numlis = new List<int>();
            while (i<5)
            {
                Console.WriteLine("Pls Enter a number:");
                try
                {
                    var num = Convert.ToInt32(Console.ReadLine());
                    if (!numlis.Contains(num))
                    {
                        numlis.Add(num);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Number already entered - retry");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input"); ;
                }
               
            }

            numlis.Sort();
            Console.WriteLine("Sorted list");
            foreach (var item in numlis)
            {
                Console.WriteLine(item);
            }
        }


        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

        static void Prob4() 
        {
            var mylis = new List<int>();
            while (true)
            {
                Console.WriteLine("Pls enter a number or type Quit to end: ");
                var ip = Console.ReadLine();
                if (ip.ToUpper() != "QUIT")
                {
                    try
                    {
                        var num = Convert.ToInt32(ip);
                        if(! mylis.Contains(num))
                        mylis.Add(num);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < mylis.Count; i++)
            {
                Console.WriteLine(mylis[i]);
            }
        }

    // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty
    //or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, 
    //display the 3 smallest numbers in the list.

        static void Prob5() {

            var thelis = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter 5 numbers seperated by ,");
                var stringArr = Console.ReadLine().Split(',');
                if(stringArr.Length == 5) 
                {
                    try
                    {
                        int[] ints = Array.ConvertAll(stringArr, s => int.Parse(s));
                        Array.Sort(ints);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(ints[i]);
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                   
                }
            }


        }

    }
}
