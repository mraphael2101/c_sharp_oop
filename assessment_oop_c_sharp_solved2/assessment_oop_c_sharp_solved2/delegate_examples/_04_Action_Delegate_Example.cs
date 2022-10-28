using System;

/*
 * Action and Func are both types of Delegates.
 * An Action does NOT have a return type.
 * It is used to prevent code duplication when implementing deligates.
 */

namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _04_Action_Delegate_Example
    {
        private string operation = "add";
        private int firstNo = 6, secondNo = 1;


        public void Start()
        {
            Action<int, int> calculation = null;

            switch (operation)
            {
                case "multiply":
                    calculation = (x, y) => Console.WriteLine(x * y);
                    break;
                case "add":
                    calculation = (x, y) => Console.WriteLine(x + y);
                    break;
            }

            ProcessData(firstNo, secondNo, calculation);
        }


        public void ProcessData(int x, int y, Action<int, int> action)
        {
            action(x, y); // Remember actions have NO return types
            Console.WriteLine("Action has been processed");
        }
    }
}