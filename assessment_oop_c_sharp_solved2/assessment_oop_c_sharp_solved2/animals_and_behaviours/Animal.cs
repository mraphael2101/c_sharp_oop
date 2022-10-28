using System;
namespace assessment_oop_c_sharp_solved2.animals_and_behaviours
{
    public abstract class Animal
    {
        private int age;
        private string name;

        public Animal()
        {
            Console.WriteLine("An instance of Animal now exists without a name");
            this.name = "Boris Johnson";
        }

        public Animal(string name)
        {
            Console.WriteLine("An instance of Animal now exists with the name " + name);
            this.name = name;
        }

        public int Age
        {
            get { return age; }

            set { age = value; }
        }


        public abstract int CalculateRandomAge();

        /* The virtual keyword is used to modify the method and to allow for it to be 
         * overridden in the derived class */
        public virtual int GenerateSecurityCode()
        {
            return 0;
        }
    }
}

