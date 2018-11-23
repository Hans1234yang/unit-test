using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            int num1 = 100;
            int num2 = 200;

            Assert.AreEqual(Program.Add(num1,num2),300);
        }
    }
}
