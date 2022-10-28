using System;

/* A property is a member that provides a flexible mechanism to read, write, 
 * or compute the value of a private field. Properties can be used as if 
 * they're public data members, but they're special methods called accessors. 
 * This feature enables data to be accessed easily and still helps promote 
 * the safety and flexibility of methods
 * 
 * 
 * A property is a member that is accessed like a field (either read or written) 
 * by some accessors so its behavior can be controlled. They're often used, for example, 
 * to update the state of an object of mutable class when setting a property to that 
 * instance. They also support lambda making them superior to Java
 */

namespace assessment_oop_c_sharp_solved2.type_examples
{
    public class _02_Properties_Example
    {
        private string name = "DEFAULT VALUE";

        public string NameProperty
        {
            get => name;
            set { name = value; }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}

