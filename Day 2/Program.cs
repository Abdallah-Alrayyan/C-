using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {

        static void task1 (double x)
        {
            Console.WriteLine("Double: " + x);
            int y = (int) x;
            Console.WriteLine("Converted Int: " + y);


        }

        static void task2(int x)
        {
            
            string y = Convert.ToString(x);
            Console.WriteLine("Your number is: " + x );

        }


        static void task3(string x)
        {

            string y = x.ToLower();
            string z = x.ToUpper();
            Console.WriteLine(y);
            Console.WriteLine(z);

        }



        static void task4(string x)
        {

            //First Name: John
            //Last Name: Doe
            //Total Characters: 8

            string First = "abdallah" ;
            string Last = "alrayyan" ;
            string fullName  = First + Last;

            Console.WriteLine($"First Name:  {First}");
            Console.WriteLine($"Last Name: {Last}");
            Console.WriteLine(fullName.Length);

        }


        static void task5(int x , int y)
        {

            if (x < y)
            {
                Console.WriteLine("Smaller Number: " +x);   
            }
            else
            {
                Console.WriteLine("Smaller Number: " + y);
            }

        }



        static void task6(double x)
        {

            

            double y = x * 0.621371;
            Console.WriteLine(y + "mph");

        }

        static void task7(int x ,int y )
        {



            int h = x * 60 ;
            int m = y * x ;

            Console.WriteLine($"Total: {m} minutes");


        }

        static void task8(int x)
        {



            double h = x / 60;
            double m = h % 60;
            

            Console.WriteLine($"{h} Hours, {m} Minutes");


        }



        static void task9A(int x ,int y)
        {

            if (x > y)
            {
                Console.WriteLine("Greater");
            }
            else if (x < y)
            {
                Console.WriteLine("Smaller");

            }
            else {
                Console.WriteLine("Equal");
            }



        }



        static void task9B(string x)
        {
    

            int g = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (char.IsDigit(x[i]))
                {
                    g += int.Parse(x[i].ToString());
                }
                else
                {
                    Console.WriteLine($"Invalid character '{x[i]}' in input string. Ignoring it.");
                }
            }

            Console.WriteLine($"The sum of digits is: {g}");
        }




        static void task10(string x)
        {

            string result = "";

            for (int i = x.Length-1; i >= 0; i--)
            {
                result += x[i]; 
            }

            Console.WriteLine(result);
        }

        static void task11(int x, int y)
        {
            if ( x % y == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");

            }



        }


        static void task12(int x, int y)
        {
            if (x % y == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");

            }



        }


        static void task13(int x, int y , int z)
        {
            if ((x > y && x < z ) || (x < y && x > z))
            {
                Console.WriteLine(x);
            }
            else if ((y > x && y < z) || (y < x && y > z))
            {
                Console.WriteLine(y);

            }else if ((z > x && z < y) || (z < x && z > y) )
            {
                Console.WriteLine(z);
            }



        }











        static void Main(string[] args)
        {
            task1(12);
            task2(12);
            task3("abd");
            task4("abdallah");
            task5(12, 10);
            task6(12.2);
            task7(1, 2);
            task8(10);
            task9A(1, 2);
            task9B("aaa");
            task10("abd");
            task11(10, 45);
            task12(12, 23);
            task13(11, 13, 12);
           
        }
    }
}
