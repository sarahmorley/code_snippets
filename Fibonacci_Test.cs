using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fib2;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 8;
            int seventhInSequence = Fib.GetNthFibonacciNo(7);
            Assert.AreEqual(seventhInSequence, number);
        }
    }
}
