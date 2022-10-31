using System;

namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _01a_Delegate_Program
    {
        public delegate void MyInterface();

        public void Start()
        {
            MyMethod();
        }


        internal virtual void MyMethod()
        {
            MyInterface x = () => MyFunc();
            x();
        }

        internal virtual void MyFunc()
        {
            Console.WriteLine("Do something");
        }
    }
}

