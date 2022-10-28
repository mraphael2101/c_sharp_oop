using System;

/*
 * A multicast delegate is an extension of a delegate.
 * 
 * All delegates are considered to be Multicast which means that
 * we can assign one or more methods to a single delegate variable
 * as per below. This is achieved using the += operator.
 * 
 * When we invoke the delegate all of the methods which are assigned
 * are run.
 * 
 * The order of delegate invocation is NOT guaranteed.
 */

namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _02_Multicast_Delegate_Program
    {
        public delegate void OperationDelegate();

        public void Start()
        {
            OperationDelegate d = null;
            d += Method1;
            d += Method2;
            d.Invoke();
        }

        public void Method1()
        {
            Console.WriteLine("Inside process 1");
        }

        public void Method2()
        {
            Console.WriteLine("Inside process 2");
        }
    }
}
