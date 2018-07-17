using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ConvertFromRomanNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void directConvertTest1()
        {


            var actual = new Convertor();

            Assert.AreEqual(3888, actual.directConvert("MMMDCCCLXXXVIII"));


        }

        [TestMethod]
        public void directConvertTest2()

        {


            var actual = new Convertor();

            Assert.AreEqual(1994, actual.directConvert("MCMXCIV"));


        }

        [TestMethod]
        public void directConvertTest3()

        {


            var actual = new Convertor();

            Assert.AreEqual(2018, actual.directConvert("MMXVIII"));


        }

        [TestMethod]
        public void directConvertTest4()

        {


            var actual = new Convertor();

            Assert.AreEqual(639, actual.directConvert("DCXXXIX"));
        }
    }
}
