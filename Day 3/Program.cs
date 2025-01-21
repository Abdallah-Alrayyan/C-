using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Program
    {

        public class HotelReservationSystem
        {

            private int RoomNumber;
            public int roomnumber
            {

                set
                {
                    RoomNumber = value;
                }

                get
                {

                    return RoomNumber;
                }

            }
            public string TypeRoom { get; set; }
            public double PricePerNight { get; set; }
            public bool IsBooked { get; set; }

            public const string HotelName = "Grand Stay Hotel";


            public HotelReservationSystem()
            {

            }

            public HotelReservationSystem(int roomNumber, string typeRoom, double pricePerNight, bool isBooked)
            {
                RoomNumber = roomNumber;
                TypeRoom = typeRoom;
                PricePerNight = pricePerNight;
                IsBooked = isBooked;
            }


            ~HotelReservationSystem()
            {

            }
        }
        static void PrintOddOrEven(int Num1)
        {
            Num1 = Convert.ToInt32(Console.ReadLine());

            if (Num1 % 2 == 0)
            {
                Console.WriteLine($"The number{Num1} is even");
            }
            else
            {
                Console.WriteLine($"The number {Num1} is odd");
            }
        }

        static int Print2nd()
        {
            int[] Arr = { 4, -3, 7, 2, 0 };

            Array.Sort(Arr);

            return Arr[1];
        }

        static int factorial(int n)
        {
            int Sum = 1;

            for (int i = n - 1; i > 0; i--)
            {
                Sum += Sum * i;
            }

            return Sum;
        }

        static bool IsPrime(int n)
        {

            int halfNumber = n / 2;

            for (int i = 2; i <= halfNumber; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

        static void PrintPrimeNumber(int From, int To)
        {


            for (int x = From; x <= To; x++)
            {
                if (IsPrime(x))
                {
                    Console.Write(x + " ");
                }

            }


        }

        static int MaxNum()
        {

            int[] Arr = { 34, 65, 31, 78, 65, 36, 97 };

            int Max = Arr[0];


            for (int i = 1; i < Arr.Length; i++)
            {
                if (Max < Arr[i])
                {
                    Max = Arr[i];
                }
            }

            return Max;
        }

        static void PrintNumbers(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }

        }

        static void PrintStarts(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("*");
                    }

                }

                Console.WriteLine();
            }

        }

        static void CalcOddAndeven(int[] Arr)
        {
            int Even = 0;
            int Odd = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    Even += Arr[i];
                }
                else
                {
                    Odd += Arr[i];
                }
            }


            Console.Write($"sum of even Numbers: {Even}");
            Console.WriteLine("\n\n");
            Console.Write($"sum of odd Numbers: {Odd}");
        }

        static void Compares(int[] Arr1, int[] Arr2)
        {
            if (Arr1.Length != Arr2.Length)
                return;

            for (int i = 0; i < Arr1.Length; i++)
            {
                if (Arr1[i] == Arr2[i])
                {
                    Console.Write($"{Arr1[i]} ");
                }
            }
        }

        static HotelReservationSystem ReadData()
        {
            HotelReservationSystem Obj = new HotelReservationSystem();

            Console.WriteLine("Enter Number of Room ?");
            Obj.roomnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Type Room ?");
            Obj.TypeRoom = Console.ReadLine();

            Console.WriteLine("Is Booked ?");
            Obj.IsBooked = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Price Per Night ?");
            Obj.PricePerNight = Convert.ToDouble(Console.ReadLine());


            return Obj;

        }

        static void PrintObj(HotelReservationSystem Obj)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Hotel Name {HotelReservationSystem.HotelName}");
            Console.WriteLine($"Room Number is {Obj.roomnumber}");
            Console.WriteLine($"Room Type is {Obj.TypeRoom}");
            Console.WriteLine($"Price Per Night {Obj.PricePerNight}");
            Console.WriteLine($"Is Booked {Obj.IsBooked}");
            Console.WriteLine("-------------------------------------------------");
        }


        static void Main(string[] args)
        {

            //1
            PrintOddOrEven(12);

            //2
            Console.WriteLine(Print2nd());

            //3
            Console.WriteLine(factorial(6));

            //4
            PrintPrimeNumber(10, 30);

            Console.WriteLine("\n\n");
            //5
            Console.WriteLine(MaxNum());

            //6
            Console.WriteLine("\n\n");
            PrintNumbers(15);

            //7
            Console.WriteLine("\n\n");
            PrintStarts(10);

            //8
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            CalcOddAndeven(Arr);

            //9
            Console.WriteLine("\n\n");
            int[] Arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] Arr2 = { 11, 2, 3, 44, 5, 56, 7 };

            Compares(Arr1, Arr2);

            //10
            HotelReservationSystem hotel1 = new HotelReservationSystem();
            HotelReservationSystem hotel2 = new HotelReservationSystem();

            hotel1 = ReadData();

            PrintObj(hotel1);


            Console.WriteLine("\n\n");

            hotel2 = ReadData();

            PrintObj(hotel2);

        }
    }
}




