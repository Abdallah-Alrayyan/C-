using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }



            public void Start()
            {
                Console.WriteLine("Vehicle is starting.");
            }
        }

        class Car : Vehicle
        {

            public int NumberOfDoors { get; set; }

        }

        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            Car car = new Car();

            car.Brand = "BMW";
            car.Model = "1999";
            car.NumberOfDoors = 10;


        }
    }
}


//1. * *What is a Constructor ? **
//   A constructor is a special method in a class that is automatically called when an object of the class is created.It is used to initialize the object’s properties and ensure the object is in a valid state.

//---

//2. **What are the Basic Concepts of OOPs?**  
//   - **Encapsulation**: Wrapping data(fields) and behavior(methods) into a single unit (class) and restricting access using access modifiers.  
//   - **Abstraction * *: Hiding implementation details and exposing only the necessary features.  
//   - **Inheritance**: Allowing a class to inherit properties and methods from another class to promote code reuse.  
//   - **Polymorphism**: Allowing methods or operations to behave differently based on the object they are acting on.

//---

//3. **What is Encapsulation?**  
//   Encapsulation is the process of bundling data and methods into a single unit (class) and restricting direct access to some of the object's components to protect data integrity and enforce controlled access.

//---

//4. **What is a Sealed Class?**  
//   A sealed class is a class that cannot be inherited. It is used to prevent other classes from deriving from it and to enforce that the functionality of the class cannot be extended.

//---

//5. * *What is the Inheritance Concept?**
//   Inheritance is the OOP concept where one class (child/derived) inherits properties, methods, and behavior from another class (parent/base). It allows for code reuse and the creation of hierarchical relationships.













