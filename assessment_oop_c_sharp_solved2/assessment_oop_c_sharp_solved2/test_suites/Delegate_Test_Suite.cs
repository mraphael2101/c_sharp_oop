using assessment_oop_c_sharp_solved2.delegate_examples;
using NUnit.Framework;

namespace assessment_oop_c_sharp_solved2
{
    public class Delegate_Test_Suite
    {
        [Test]
        public void Test1a()
        {
            new _01a_Delegate_Program().Start();
        }

        [Test]
        public void Test1b()
        {
            new _01b_Delegate_Program().Start();
        }

        [Test]
        public void Test2()
        {
            new _02_Multicast_Delegate_Program().Start();
        }


        [Test]
        public void Test3()
        {
            new _03_Multicast_Delegate_Real_Example().Start();
        }

        [Test]
        public void Test4()
        {
            new _04_Action_Delegate_Example().Start();
        }

        [Test]
        public void Test5()
        {
            new _05_Func_Delegate_Example().Start();
        }
    }
}
