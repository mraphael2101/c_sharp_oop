using System;

/*
 * A delegate allows you to pass a method around just like you would
 * using conventional data which is a powerful concept
 */

namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _03_Multicast_Delegate_Real_Example
    {
        public delegate int OperationalDelegate(int x, int y);

        private static string operation = "add";
        private static int firstNo = 9, secondNo = 1;


        public void Start()
        {
            OperationalDelegate calculation = null;

            switch (operation)
            {
                case "multiply":
                    calculation = (x, y) => x * y;
                    break;
                case "add":
                    calculation = (x, y) => x + y;
                    break;
            }

            ProcessData(firstNo, secondNo, calculation);
        }


        public void ProcessData(int x, int y, OperationalDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine("Result = " + result);
        }
    }
}