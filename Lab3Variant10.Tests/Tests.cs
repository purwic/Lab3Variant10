using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lab3Variant10.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CheckNumberX_Enter1_AnswerMinus1()
        {
            int x = 1; 
            int excpected = -1;
            int actual = Class1.method(x);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter10_Answer0()
        {
            int x = 10;
            int excpected = 0;
            int actual = Class1.method(x);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter24_Answer8()
        {
            int x = 24;
            int excpected = 64;
            int actual = Class1.method(x);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter100_Answer0()
        {
            int x = 100;
            int excpected = -1;
            int actual = Class1.method(x);
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter101_AnswerMinus1()
        {
            int x = 101;
            int excpected = -1;
            int actual = Class1.method(x);
            Assert.AreEqual(excpected, actual);
        }
    }
}
