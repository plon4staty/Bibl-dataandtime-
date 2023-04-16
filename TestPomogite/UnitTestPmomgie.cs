using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MAnipulFromDate;
using System.Security.AccessControl;

namespace TestPomogite
{
    [TestClass]
    public class UnitTestPmomgie
    {
        [TestMethod]
        public void TestMethodDateWithDate()
        {
            
            IsDae isDae = new IsDae();


            string Day_1 = "январь";
            string Day_2 = "февраль";
            int expected = 59;

            int actual = isDae.DateWithDae(Day_1, Day_2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodLeapYear()
        {

            IsDae isDae = new IsDae();


            int Day_1 = 2003;
            string expected = "Год не высокосный";

            string actual = isDae.LeapYear(Day_1);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodTimeOfDay()
        {

            IsDae isDae = new IsDae();


            int Day_1 = 12;
            string expected = "Сейчас утро";

            string actual = isDae.TimeOfDay(Day_1);

            Assert.AreEqual(expected, actual);

        }
    }
}
