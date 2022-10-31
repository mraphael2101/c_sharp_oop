using System;
namespace assessment_oop_c_sharp_solved2.delegate_examples
{
    public class _01b_Delegate_Program
    {
        public delegate string OperationDelegate(int x, int y);

        public void Start()
        {
            OperationDelegate d1 = new OperationDelegate(MyMethod);

            string invokeRequest = d1.Invoke(9, 1);
            Console.WriteLine(invokeRequest);
        }

        private string MyMethod(int x, int y)
        {
            return $"int x {x} int y {y}";
        }
    }
}
