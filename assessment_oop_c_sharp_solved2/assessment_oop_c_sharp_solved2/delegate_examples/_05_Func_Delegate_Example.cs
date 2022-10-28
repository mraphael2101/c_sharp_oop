using System;

/*
 * Action and Fun are both types of Delegates.
 * A Func will always have a return type.
 * It is used to prevent code duplication when implementing deligates.
 */

namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _05_Func_Delegate_Example
    {
        private string operation = "add";
        private int firstNo = 4, secondNo = 1;

        public void Start()
        {
            // Pay attention: Func<arg1, arg2, retType> myFunc
            Func<int, int, int> calculation = null;

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

        public void ProcessData(int x, int y, Func<int, int, int> func)
        {
            var result = func(x, y);
            Console.WriteLine(result);
        }
    }
}