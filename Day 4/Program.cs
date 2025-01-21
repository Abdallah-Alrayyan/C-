using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day_4
{
    internal class Program
    {


        class student
        {
            public string Name { get; set; } // property 
            public int Age { get; set; }
            public int StudentID { get; set; }

            public string Email { get; set; }


            const int MinAge = 18; // constant  

            const int MaxAge = 40;

            public student(string Name, int Age, int StudentID, string Email) // constructor 
            {

                this.Name = Name;
                this.Age = Age;
                this.StudentID = StudentID;
                this.Email = Email;

            }


            public  void GetDetails() { // method

                Console.WriteLine($"StudentName:{Name}\nStudentAge:{Age}\nStudentID:{StudentID}\nStudentEmail:{Email}");

            }









            static void Main(string[] args)
            {
                student abd = new student("abd", 20, 1221, "aaa");  // object
                student abdallah = new student("abdallah", 20, 1, "a@a.com");
                abd.GetDetails();
                abdallah.GetDetails();
                Console.ReadKey();
            }
        }
    }
}



//1- A class is a template or blueprint we use it to make the code more organized
//2- An object is an instance of the class to spacify values to the class properties
//3- An object is an instance of the class (Part Of It)
//4- Encapsulation, Abstract, polymorphism and inheritance
//5- A property is a way to encabsulate the class feild so we can print or modify the feilds without a direct access to it
//6- A feild is a normal variable declared inside a class.
//7- A Constructor is a special method to initialize the object feilds and it will be executed automatically when we create an object
//8- Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is necessery
