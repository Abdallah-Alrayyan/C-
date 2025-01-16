

using System;

namespace C__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");

            string name =Console.ReadLine();

            Console.WriteLine(name);



            int num = 5;
            string name2 = "abd";
            double num2 = 2.5;
            float num3 = 1.1f;
            char name3 = 'a';
            bool boolen = false;
            const int num4 = 5;

            Console.WriteLine(num);
            Console.WriteLine(name2);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(name3);
            Console.WriteLine(boolen); 
            Console.WriteLine(num4);



            string[] car = { "BMW", "BYD", "HAVAL" , "GMC" };

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }

            Console.Write("Input your firstname:");
            string firstname = Console.ReadLine();
            Console.Write("Input your lastname:");
             string lastname = Console.ReadLine();
            Console.Write("Input your year of birth:");
            int birth = Convert.ToInt32( Console.ReadLine());
            Console.Write(firstname + " " + lastname + " " + birth);


           



















        }
    }
}
