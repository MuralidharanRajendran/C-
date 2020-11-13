using ConsoleApp1_Mosh.PersonFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class NewClass
    {
        public string LastName { get; private set; }

        //***********VIRTUAL KEUWORD*****************************
        //IMORTANT - Virtual keyword
        //This allows a method in the parent class to be over ridden

        //You have to to use the override keyword here
        public void Method()
        {
            Console.WriteLine("This is a overriden method");



            //***************Static Keyword*************************
            //You can use the static keyword to access a calss without its object
            //When you create objects it creates individual memory locationd for each objects

            //When you decalre it static the class itself is there in the memory, so You can just 
            //access it using the calss name

            //The main method() has only one instance - Objects cannot be created for it
            IamaAstaticClass.IamaAstaticMethod();

            //Only when a class is public you can create an object for it and use it 
            //If Person calss was not public, you could hyave not created an object for it


            //*********************Creating Objects********************
            //WOW This is cool - Just Press alt+ Enter and take the first suggestion
            var obj = new Person
            {
                FirstName = "Murali",
                LastName = "Dhar"
            };

        }
    }
}
