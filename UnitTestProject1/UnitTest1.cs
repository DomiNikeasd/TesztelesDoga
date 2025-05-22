using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var asd = new Program();
            string result = "Tél";
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var asd = new Program();
            string result = "Tavasz";
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var asd = new Program();
            string result = "Ősz";
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var asd = new Program();
            string result = "Nyár";
            Assert.AreEqual(result, 4);
        }
    }
}
