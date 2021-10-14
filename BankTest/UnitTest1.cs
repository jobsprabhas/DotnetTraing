using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("I am Test 1");
        }

        public void Test2()
        {
            Console.WriteLine("I am Test 2");
        }

        [TestMethod]
        public void NotATest()
        {
            Console.WriteLine("I am Not a Test");
        }

    }
}
