using System;
using assessment_oop_c_sharp_solved2.animals_and_behaviours;

namespace assessment_oop_c_sharp_solved2
{
    public class Main
    {
        public static void Start()
        {
            // Calling an Overloaded Method
            new Bird().CalculateRandomAge(5);

            // Calling an Overridden Method
            new Bird().CalculateRandomAge();

            // Accessing the internal structure of an object (Encapsulation)
            Bird objRef = new Bird();
            objRef.Age = 5;
            Console.WriteLine(objRef.Age);


            // Polymorphism ******************************************************************

            // 1) Complete the code to demonstrate polymorphism using the Object class in Java
            BlackSparrow blackSparrow1 = new BlackSparrow();
            Bird bird1 = (Bird)blackSparrow1;
            Object bird1Obj = blackSparrow1;


            // 2) Complete the code to demonstrate upcasting:
            Bird blackSparrow2 = new BlackSparrow();


            // 3) Complete the code to demonstrate downcasting:
            Bird bird = new BlackSparrow();
            BlackSparrow blackSparrow3 = (BlackSparrow)bird;

            // End ****************************************************************************
        }
    }
}

