using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1_Mosh.PersonFolder
{
    public class Excercise
    {

        //Press Alt + Enter to get the suggestion
        // It will just create a new class for you

        public static void Main(string[] args) {

            Prob1();
        }

        //1- Write a program that reads a text file and displays the number of words.
        // C:\Users\mural\source\repos\C-\C-\ConsoleApp1_Mosh\WorkingWithFiles
        public static void Prob1()
        {
            var pat = @"C:\Users\mural\source\repos\C-\C-\ConsoleApp1_Mosh\WorkingWithFiles\sample.txt";
            var fi = new FileInfo(pat);
            File.WriteAllText(pat,"This is inside the file");
            var strArr = File.ReadAllText(pat).Trim().Split(" ");
            Console.WriteLine(strArr.Length);

            //Displaying the longest word
            var longestWord = "";
            foreach (var item in strArr)
            {
                if (item.Length > longestWord.Length)
                {
                    longestWord = item;
                }
            }
            Console.WriteLine(longestWord);
        }


    }
}
