using System;
using assessment_oop_c_sharp_solved2.animals_and_behaviours;

namespace assessment_oop_c_sharp_solved2.animals_and_behaviours
{
    public class Bird : Animal, ICanFly, IHop
    {
        // Unlike in Java, this is actually implementing the method declaration and NOT overriding it in C#
        public void Fly(double altitude, double speed)
        {
            Console.WriteLine("altitude : " + altitude + "speed : " + speed);
        }

        // Overriding
        public override int CalculateRandomAge()
        {
            return 0;
        }

        // Overloading
        public int CalculateRandomAge(int factor)
        {
            return 0;
        }
    }
}