using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Mosh
{
    class NewClass2
    {
        //about classes
        // In C# You have to explicitly allocate memory for calsses
        // CLR will take care of that for you
        // Garbage collection to remove unused objects

        




        //Lets assume you should be able to allow only a particular value of 
        //rating that has to be passed to a movie
        public string title;
        public string director;
        private string rating;

        //Only this calss can access the rating variables - since its private
        public NewClass2(string title, string director, string rating) {

            this.title = title;
            this.director = director;

            //Here you are setting the rating with the help of the setter method below
            Rating = rating;


        }

        // GETTERS AND SETTERS - They are used to control the access of the attributes of a class - It makws class morw secure

        public string Rating
        {
            get { return rating; } //Allows us to get the rating
             //Allows us to set the rating

            set 
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;

                }
                else
                {
                    rating = "NR";
                }
            }
        }


    }
}
