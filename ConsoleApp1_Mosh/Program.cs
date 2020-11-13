using System;

//Simple comparison C# with Java
// 1. namespace - Packages
// 2. Assemblies (.exe or dynamically linked librabry (dll)) - jar
// Namespaces contains mulitple classes
// Assemblies contains related name spaces
// When you compile the program it is going to generate an assemble .exe file and display the output -
//This is done with the help of CLR


namespace ConsoleApp1_Mosh
{
    class Program : NewClass
    {
        static void Main(string[] args)
        {
            // Whatever program I want, I have to make sure I am putting it inside of this main, 
            //Because the execution starts from here


            //************************************************
            // 14. Classes and objects in C#


            // Creating an object for an other calss
            NewClass obj = new NewClass();
            //obj.number = 10;
            //Console.Write(obj.title);
            //obj.title = "frog";


            // Creating an object using var keyword
            var newobj = new NewClass();
            newobj.Method();


            //*****************************************************************************//

            // 1. Printing line in C#
            Console.WriteLine("Hello\"World!");
            // Console.ReadLine();
            //Format string
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //*****************************************************************************//

            // 2. Storing decimlas in C#
            // float, double, decimal -- Least Accurate to most accurate. (i,e) decimal is the most accurate
            double gpa = 3.0;
            bool isMale = true;
            const float pi = 3.14f;
            //pi = 10; //You cannot change the value of a constant

            //*****************************************************************************//

            // Type conversion in C# Byte -> 1 byte (Max integer value = 256 - after 256 it ll become 1) 
            //Integer -> 4 bytes
            // 1. Implicit conversion 
            byte b = 1;
            int num = b; // This is possible because int can contain more bytes than a byte
            // So no data loss here
            int i = 1;
            float f = i; //This is also possible - so no data loss will happen

            int j = 1;
            // byte m = j; //This will throw a compile time error as bytes can contain lesser number of bytes than int

            //However if you typecast its possible
            //This is called Explicit conversion
            byte m = (byte)j;

            //*****************************************************//
            //casting String to a number
            string cast = "1023";
            //int o = (int)cast; //This is not possible
            // so this can be done by using parse
            int o = int.Parse(cast);
            //Note that unlike Java here you are using the primitive data type itself to parse
            //All the primitive type has this parse method

            //This is an other way of doing the same - but by using Convert calss
            int t = Convert.ToInt32(cast);
            //int16 - Short
            //int32 - int
            //intt64 - long


            var ran = "1234";
            int Ran = int.Parse(ran);
            int Rand = Convert.ToInt32(ran);

            //********PRE FIX AND POST FIX**********************
            //Postfix
            int bbye = 1;
            int bn = bbye++; //Result  b = b+1 but bn = 1

            //Prefix
            int l = 5;
            int ln = ++l; //Here first l is incremented by 1 and then its assigned to ln
            //Result l = 6 and ln = 6

            //int man;
            //int man += 4; //~~~~~~~~~~~~~~~PLS CHK~~~~~~~~~~~~~~~~~~~~~~~

            //Bitwise operators & |
            // logical operator && ||

            //*****************************************************************************//

            // 3. Operations in strings
            string name = "Murali dhAran";
            int len = name.Length;
            string UpperVal = name.ToUpper();
            string substr = name.Substring(3);
            char thechar = name[0];
            // Important - Strings are mutable in C# but not in Java


            //It return the first occuring character, if the character is not htere its going to return -1
            int index = name.IndexOf('A');
            string substr2 = name.Substring(8, 3);
            //SubString(Stringfrom, untilWhere)


            /*  Console.WriteLine(len);
              Console.WriteLine(UpperVal);
              Console.WriteLine(substr2);
              Console.WriteLine(thechar);
              Console.WriteLine(index); */

            //*****************************************************************************//
            // 4. Number is C# using Math library
            double mynum = -24.5;

            //Absolute value - returns only the positive value of the number
            double absNum = Math.Abs(mynum);
            // Console.WriteLine(Math.Pow(absNum,2));

            //*****************************************************************************//
            // 5. Getting input from users

            //This will always return a string
            //Difference between write Line and write - Write will allow you to enter the string in the same line
            //Console.Write("Enter your input ");
            //string userIP = Console.ReadLine();
            //Console.WriteLine("You Entered : " + userIP);

            //6. Basic calculator program in C#
            //Converting a string into a number
            /*  Console.Write("Enter your input1 ");
              double nu1 = Convert.ToDouble(Console.ReadLine());
              Console.Write("Enter your input2 ");
              int num2 = Convert.ToInt32(Console.ReadLine());
              Console.Write(nu1 + num2); */

            //*****************************************************************************//
            // 7. Arrays

            //Arrays are mutable - similar to java - it contains the same data type
            int[] MyArray = { 1, 2, 3, 4, 5, 6 };
            MyArray[3] = 900;
            int res = MyArray[4] + MyArray[3];

            //************Assigning size to an array******************
            // Array is an object, thats why we use the new keyword to create it

            string[] StringArray = new string[4];


            //*****************************************************************************//
            // 8. Mehtods in C#
            //See method declaration below
            // Calling the static method
            SayHi("Murali");


            //*****************************************************************************//
            //9. Return statements
            double result = CubeNumber(3);
            Console.WriteLine(result);



            //*****************************************************************************//

            //10. Conditional statemtns
            // if (a && b){
            //Condition 1
            //}
            //else if(condition || !condition){
            // condition 2
            //}
            //else {
            // condition 2
            //}


            //*****************************************************************************//
            // 10. Switch statements
            Console.WriteLine(GetDay(1));


            //*****************************************************************************//
            // 11. While, do while,for loops in C# -  same as Java



            //*****************************************************************************//

            // 12. Two dimensional arrays in C#
            // 2D
            int[,] numberMatrix = { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            // Printing those numbers
            Console.WriteLine(numberMatrix[0, 0]);

            //Declaraing an array
            int[,] declareArray = new int[2, 3]; //-> { 1, 2 }, { 2, 3 }, { 3, 4 } 2 colums and 3 rows


            //3D
            // int[, ,] numberMatrixTwo = { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 6 } };

            // Printing those numbers
            Console.WriteLine(numberMatrix[0, 0]);


            //*****************************************************************************//

            //13. Exception in C#
            try
            {
                int val1 = 5;
                int val2 = 0;
                int results = val1 / val2;


            }

            //The below block will catch only arithmetic exception, so you can perform actions based on that
            catch (ArithmeticException e)
            {

                Console.Write(e.Message);
            }


            catch (FormatException e)
            {
                Console.Write(e.Message);
            }

            finally {
                //This will always be executed

                Console.Write("This will always be executed");
            }



            //*****************************************************************************//
            // 14. GETTERS AND SETTERS - They are used to control the access of the attributes of a class - It makws class morw secure
            NewClass2 obj2 = new NewClass2("Bahubali", "RM" , "Sooper");
            Console.Write(obj2.title);

            //Here since sooper is invalid - by default it print NR on the console
            Console.Write(obj2.Rating);


            // 15. Static class and attributes
            // Static attribute is a special type of attribute in a class which is shared by all of the objects in a class
            //This attribute is contained on the class itself, instead of an individual object of a class
            //It is not unique to the object, its unique to a class
            // public static method can be used anywhere in the project
            // For example Math.sqrRoot(144);  As you can see we have not created an object for Math class
            //But we were able to access it. This is the use of a static class
            // Ypu cannot create an object for a static class 


            // 16. Inheritance in C#
            // class child : parent
            //You have to use virtual in parent and override  in child to sucesfully override a method

            Program newObj = new Program();
            newObj.Method();




    }


        //*****************************************************************************//
        // 8. Method Declaration
        //Method name starts with a capital letter
        static void SayHi(string name) 
        {

          //  Console.WriteLine("Hello  " + name);
        }


        //*****************************************************************************//

        //9. return type
        static double CubeNumber(int num)
        {
            double r = Math.Pow(num, 3);
            return r;
        }



        //*****************************************************************************//

        //10. Switch statement
        static string GetDay(int dayNum) 
        {
            string dayName;

            switch (dayNum) {

                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                default:
                    dayName = "Invalid number";
                    break;

            }

            return dayName;
        }
    }
}
