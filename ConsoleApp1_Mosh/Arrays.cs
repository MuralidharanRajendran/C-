using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class Arrays
    {

        //Instead of declaring 3 integers like below
        // int num1;
        // int num2;
        // int num3;

        //With the help of array you can easily create the below

        int[] numbers = new int[3];
        //Arrays haev fixed size.
        //The size once you fix cannot be changed
        //WHY ARE WE USING NEW KEYWORD HERE

        //When creating an array you have to allocate memory for it
        //Thats why like creating objects u use the new keyword here
        // And also array is an object

        // You do this when you already know the values which you want to save in the aray
        int[] nums = { 1, 2, 3 };

        //The above can be also wrritten as
        int[] number = new int[3] { 1, 2, 3 };

        static void main(String[] args) { 

        //Much more simply - but note that you can use this only within a method
        var numb = new int[4];

        Console.WriteLine("ctl+d");
        Console.WriteLine("ctl+d"); 
        Console.WriteLine("ctl+d");
        
        //By default wen Boolean Values are just initalised but not set any value
        //It will be FALSE




        }
    }
}
