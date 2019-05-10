using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public static int i = 0;

        [TestMethod]
        [Owner("some1")]
        [Priority(1)]
        public void TestMethod11()
        {

            Assert.IsTrue(i++ % 4 == 0);

        }


        [TestMethod]
        [Owner("some2")]
        [Priority(2)]
        public void TestMethod21()
        {
            Assert.IsTrue(i++ % 4 == 0);

        }

        [TestMethod]
        [Owner("some3")]
        [Priority(1)]
        public void TestMethod31()
        {
            Console.Error.WriteLine("iteration {0}", i);
            Assert.IsTrue(i++ % 4 == 0);
        }


        [TestMethod]
        [Owner("some1")]
        [Priority(3)]
        public void TestMethod41()
        {
            Assert.AreEqual(i++ % 4, 0, string.Format("value of i = {0}", i));
        }

        [TestMethod]
        public void Pass1()
        {
            System.Threading.Thread.Sleep(30000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass2()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass3()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass4()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Fail1()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void Fail2()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Pass10()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass20()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass30()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass40()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Fail10()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void Fail20()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Pass11()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass21()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass31()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass41()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Fail11()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void Fail21()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Pass12()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass22()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass32()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Pass42()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void Fail12()
        {
            Assert.IsFalse(true);
        }
        [TestMethod]
        public void Fail22()
        {
            Assert.IsFalse(true);
        }
    }
}
