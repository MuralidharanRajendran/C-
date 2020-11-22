using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh.ArraysAndList
{

    //Arrays have fixed size - They can only have same data type - And also you have to declare the size in advance
    // Array : Fixed size
    // List : dynamic size
    // List is a generic type
    // "In C#, generic means not specific to a particular data type."

    //So when you dont know how many objects you are going to store in a data structure go for list

    class LetsList
    {

        public static void main() {

            // Declaration
            // var arr = new int[3];
            var number = new List<int>();
            var numlis = new List<int>() { 1, 2, 3, 4 };

            //Useful methods
            // 1. Add() - Add an object
            numlis.Add(1);

            // 2. AddRange() - Add a range of objects ~ (May be another list, Array)
            //Whenever you see Ienumarable you can use Array or List
            //Lets create a ne warray here
            numlis.AddRange(new int[3] { 5, 6, 7 });
            numlis.AddRange(new List<int>() { 3, 4, 5 }); //Adding a list to it

            foreach (var item in numlis)
            {
                Console.WriteLine(item);
            }

            // 3. Remove()
            // In c# we are not allowed to modify our collection inside for each loop
            

            for (int i = 0; i < numlis.Count; i++)
            {
                if (numlis[i] == 1) {
                    numlis.Remove(numlis[i]); // you cant put this in a for each loop - This throws an exception
                     // But you can use a for loop
                }
            }
           
            // 4. RemoveAt()
            // 5. IndexOf()
            int index = numlis.IndexOf(3);

            // 6. Contains()
            // 7. Count() - No of objects in the list
            int count = numlis.Count;

            //8. Removes all elements in the lsit - This will return the cout to be 0

        }
    }
}
