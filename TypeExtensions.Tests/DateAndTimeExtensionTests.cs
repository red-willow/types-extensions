using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedWillow.Extensions;

namespace TypeExtensions.Tests
{
    [TestClass]
    public class DateAndTimeExtensionTests
    {
        [TestMethod]
        public void DaysIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), 1.Days());
            Assert.AreEqual(new TimeSpan(-1, 0, 0, 0), -1.Days());
        }
        [TestMethod]
        public void HoursIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(1, 0, 0), 1.Hours());
            Assert.AreEqual(new TimeSpan(-1, 0, 0), -1.Hours());
        }

        [TestMethod]
        public void MinutesIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(0, 1, 0), 1.Minutes());
            Assert.AreEqual(new TimeSpan(0, -1, 0), -1.Minutes());
        }

        [TestMethod]
        public void SecondsIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(0, 0, 1), 1.Seconds());
            Assert.AreEqual(new TimeSpan(0, 0, -1), -1.Seconds());
        }

        [TestMethod]
        public void MillisecondsIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(0, 0, 0, 0, 1), 1.Milliseconds());
            Assert.AreEqual(new TimeSpan(0, 0, 0 , 0, -1), -1.Milliseconds());
        }

        [TestMethod]
        public void TicksIntegerTest()
        {
            Assert.AreEqual(new TimeSpan(1), 1.Ticks());
            Assert.AreEqual(new TimeSpan(-1), -1.Ticks());
        }

        [TestMethod]
        public void DaysShortTest()
        {
            Assert.AreEqual(new TimeSpan(1, 0, 0, 0), ((short)1).Days());
            Assert.AreEqual(new TimeSpan(-1, 0, 0, 0), ((short)-1).Days());
        }
        [TestMethod]
        public void HoursShortTest()
        {
            Assert.AreEqual(new TimeSpan(1, 0, 0), ((short)1).Hours());
            Assert.AreEqual(new TimeSpan(-1, 0, 0), ((short)-1).Hours());
        }

        [TestMethod]
        public void MinutesShortTest()
        {
            Assert.AreEqual(new TimeSpan(0, 1, 0), ((short)1).Minutes());
            Assert.AreEqual(new TimeSpan(0, -1, 0), ((short)-1).Minutes());
        }

        [TestMethod]
        public void SecondsShortTest()
        {
            Assert.AreEqual(new TimeSpan(0, 0, 1), ((short)1).Seconds());
            Assert.AreEqual(new TimeSpan(0, 0, -1), ((short)-1).Seconds());
        }

        [TestMethod]
        public void MillisecondsShortTest()
        {
            Assert.AreEqual(new TimeSpan(0, 0, 0, 0, 1), ((short)1).Milliseconds());
            Assert.AreEqual(new TimeSpan(0, 0, 0, 0, -1), ((short)-1).Milliseconds());
        }

        [TestMethod]
        public void TicksShortTest()
        {
            Assert.AreEqual(new TimeSpan(1), ((short)1).Ticks());
            Assert.AreEqual(new TimeSpan(-1), ((short)-1).Ticks());
        }

        [TestMethod]
        public void TicksLongTest()
        {
            Assert.AreEqual(new TimeSpan(1), 1L.Ticks());
            Assert.AreEqual(new TimeSpan(-1), -1L.Ticks());
        }
    }
}
