using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh

{


    public class Person{

        public int Age;

    }
    class ReferenceAndValueTypeDemo
    {

        public static void main(string[] args)
        {
            //Though the variable name number is same -they are different memory locations
            // So they donot coantain the same value -Change in one variable will not impact the pther
            //Vlue type
            var number = 1;
            increment(number); //1
            //Here the value is not incremented - Value Type
            //This is because the varaible name number is local to the main type -it has no scope out of it

            //Reference type
            var maadu = new Person() { Age = 20 };
            makeOld(maadu); //Pasisng the object here
            //This object person is not local to the main method, so it will increment the value in both the methods
            Console.WriteLine(maadu.Age); //30
        }

        public static void increment(int number) {

            number += 10;
        }

        //Here you are using the Reference type -> As you are using the Person Object here
        public static void makeOld(Person aadu) {

            aadu.Age += 10;
            Console.WriteLine(aadu.Age); //30
           
            //Ways of declaring arrays
            int[] num = { 2, 2, 3 };
            int[] numb = new int[3];
            int[] number = new int[3] { 4, 5, 6 };
            var numbe = new int[4];
             _ = new int[4];
        }
    }
}
