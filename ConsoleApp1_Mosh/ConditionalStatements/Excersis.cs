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

            // 2. Write a program which takes two numbers from the console and displays the maximum of the two.
            try
            {
                Console.WriteLine("Enter the first number: ");
                string val1 = Console.ReadLine();
                var int1 = Int32.Parse(val1);
                Console.WriteLine("Enter the second number: ");
                string val2 = Console.ReadLine();
                var int2 = Int32.Parse(val2);

                int res = (int1 > int2) ? int1 : int2;
                Console.WriteLine(string.Format("The greatest number is {0}", res));
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            
            
        }


        public static void prob3() {

            try
            {
                // 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

                //Landscape

                // Size: 1920 x 1080 px
                // Aspect ratio: 16:9
                //Portrait

                //Size: 1080 x 1920 px
                //Aspect Ratio: 9:16

                Console.WriteLine("Enter the length: ");
                string length = Console.ReadLine();
                var len = Int32.Parse(length);

                Console.WriteLine("Enter the breadth: ");
                string breadth = Console.ReadLine();
                var b = Int32.Parse(breadth);

                if (len == 1920 && b == 1080)
                {

                    Console.WriteLine("Landscape");
                }

                else if (b == 1920 && len == 1080)
                {

                    Console.WriteLine("Potrait");
                }

                else {
                    Console.WriteLine("Invalid dimensions");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        
        }


        public static void prob4()
        {

            // 4. Your job is to write a program for a speed camera. 
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
            //Write a program that asks the user to enter the speed limit. 
            //Once set, the program asks for the speed of a car. 
            //If the user enters a value less than the speed limit, program should display Ok on the console. 
            //If the value is above the speed limit, 
            //the program should calculate the number of demerit points. 
            //For every 5km/hr above the speed limit, 
            //1 demerit points should be incurred and displayed on the console. 
            //If the number of demerit points is above 12, the program should display License Suspended.
            try
            {
                //Enter the speed limit
                Console.WriteLine("Enter the speed limit: ");
                var splim = Console.ReadLine();
                int speedlimit = Int32.Parse(splim);
                //Enter speed of car
                Console.WriteLine("Enter the speed of the car: ");
                var carsp = Console.ReadLine();
                int carspeed = Int32.Parse(carsp);


                if (carspeed >= speedlimit + 60) {
                    Console.WriteLine("Licence cancelled");
                }
                else
                {
                    Console.WriteLine("demeritPts ~ 0");
                    Console.WriteLine("Ok");
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

            public static void Main(string[] args) {

            prob4();


        }
    }
}
