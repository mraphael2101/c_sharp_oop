using System;
using assessment_oop_c_sharp_solved2.type_examples;
using NUnit.Framework;

namespace assessment_oop_c_sharp_solved2
{
    public class Other_Tests
    {
        [Test]
        public void Test1()
        {
            _02_Properties_Example propExample = new _02_Properties_Example();
            propExample.PrintName();
            propExample.NameProperty = "Mark";
            propExample.PrintName();
        }
    }
}

