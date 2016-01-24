using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using RedWillow.Extensions;

namespace TypeExtensions.Tests
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void FromNowTest()
        {
            var expected = DateTime.Now.AddDays(1);
            var result = new TimeSpan(1, 0, 0, 0).FromNow();

            result.Should().BeCloseTo(expected);
        }

        [TestMethod]
        public void FromNowUtcTest()
        {
            var expected = DateTime.UtcNow.AddDays(1);
            var result = new TimeSpan(1, 0, 0, 0).FromNowUtc();

            result.Should().BeCloseTo(expected);
        }

        [TestMethod]
        public void AgoTest()
        {
            var expected = DateTime.Now.AddDays(-1);
            var result = new TimeSpan(1, 0, 0, 0).Ago();

            result.Should().BeCloseTo(expected);
        }

        [TestMethod]
        public void AgoUtcTest()
        {
            var expected = DateTime.UtcNow.AddDays(-1);
            var result = new TimeSpan(1, 0, 0, 0).AgoUtc();

            result.Should().BeCloseTo(expected);
        }

        [TestMethod]
        public void IsSundayTest()
        {
            var dt = new DateTime(2016, 1, 3);

            dt.IsSunday().Should().BeTrue();
            dt.IsMonday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsSunday().Should().BeFalse();
        }

        [TestMethod]
        public void IsMondayTest()
        {
            var dt = new DateTime(2016, 1, 4);

            dt.IsMonday().Should().BeTrue();
            dt.IsTuesday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsMonday().Should().BeFalse();
        }

        [TestMethod]
        public void IsTuesdayTest()
        {
            var dt = new DateTime(2016, 1, 5);

            dt.IsTuesday().Should().BeTrue();
            dt.IsWednesday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsTuesday().Should().BeFalse();
        }

        [TestMethod]
        public void IsWednesdayTest()
        {
            var dt = new DateTime(2016, 1, 6);

            dt.IsWednesday().Should().BeTrue();
            dt.IsThursday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsWednesday().Should().BeFalse();
        }

        [TestMethod]
        public void IsThursdayTest()
        {
            var dt = new DateTime(2016, 1, 7);

            dt.IsThursday().Should().BeTrue();
            dt.IsFriday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsThursday().Should().BeFalse();
        }

        [TestMethod]
        public void IsFridayTest()
        {
            var dt = new DateTime(2016, 1, 8);

            dt.IsFriday().Should().BeTrue();
            dt.IsSaturday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsFriday().Should().BeFalse();
        }

        [TestMethod]
        public void IsSaturdayTest()
        {
            var dt = new DateTime(2016, 1, 9);

            dt.IsSaturday().Should().BeTrue();
            dt.IsSunday().Should().BeFalse();

            dt = dt.AddDays(1);
            dt.IsSaturday().Should().BeFalse();
        }

        [TestMethod]
        public void IsAfterNowTest()
        {
            var dt = DateTime.Now.AddDays(1);

            dt.IsAfterNow().Should().BeTrue();
            DateTime.Now.IsAfterNow().Should().BeFalse();
        }

        [TestMethod]
        public void IsAfterNowUtcTest()
        {
            var dt = DateTime.UtcNow.AddDays(1);

            dt.IsAfterNowUtc().Should().BeTrue();
            DateTime.UtcNow.IsAfterNowUtc().Should().BeFalse();
        }

        [TestMethod]
        public void IsAfterTest()
        {
            var dt = DateTime.Now;

            dt.AddDays(1).IsAfter(dt).Should().BeTrue();
            dt.IsAfter(dt).Should().BeFalse();
        }

        [TestMethod]
        public void IsBeforeNowTest()
        {
            var dt = DateTime.Now.AddDays(-1);

            dt.IsBeforeNow().Should().BeTrue();
            DateTime.Now.IsBeforeNow().Should().BeFalse();
        }

        [TestMethod]
        public void IsBeforeNowUtcTest()
        {
            var dt = DateTime.UtcNow.AddDays(-1);

            dt.IsBeforeNowUtc().Should().BeTrue();
            DateTime.UtcNow.IsBeforeNowUtc().Should().BeFalse();
        }

        [TestMethod]
        public void IsBeforeTest()
        {
            var dt = DateTime.Now;

            dt.AddDays(-1).IsBefore(dt).Should().BeTrue();
            dt.IsBefore(dt).Should().BeFalse();
        }
    }
}
