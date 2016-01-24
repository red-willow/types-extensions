using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedWillow.Extensions;
using FluentAssertions;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TypeExtensions.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void TitleCaseTest()
        {
            var str = "This has a miXEd set of w0rd5 in it. A-bit   here.";

            str.TitleCase().Should().Be("This Has A miXEd Set Of w0rd5 In It. A-bit   Here.");
            str.TitleCase(true).Should().Be("This Has A MiXEd Set Of W0rd5 In It. A-bit   Here.");
        }

        [TestMethod]
        public void IsMatchTest()
        {
            var str = "A super string";

            str.IsMatch("s[uU]per [sS]tring").Should().BeTrue();
            str.IsMatch("^a").Should().BeFalse();
        }

        [TestMethod]
        public void IsMatchExtendedTest()
        {
            var str = "A super string";

            str.IsMatch("s[U]per [S]tring", RegexOptions.IgnoreCase).Should().BeTrue();
            str.IsMatch("^a", RegexOptions.IgnoreCase).Should().BeTrue();
        }

        [TestMethod]
        public void ReReplaceTest()
        {
            var str = "Cost of $37.95 per week.";

            str.ReReplace("[0-9]+(\\.[0-9]+)?", "0.00").Should().Be("Cost of $0.00 per week.");
            str.ReReplace("\\$([0-9]+(\\.[0-9]+)?)", "{$1 NZD}").Should().Be("Cost of {37.95 NZD} per week.");
        }

        [TestMethod]
        public void ReReplaceReadmeTest()
        {
            var str = "$39.95 per week";

            str.IsMatch("^\\$?[0-9]+\\.[0-9]{2}").Should().BeTrue();
            str.ReReplace("([0-9]+\\.[0-9]{2})", "0.00 (usually $1)").Should().Be("$0.00 (usually 39.95) per week");
        }

        [TestMethod]
        public void ReReplaceExtendedTest()
        {
            var str = "Cost of $37.95 per week.";

            str.ReReplace("[0-9]+(\\.[0-9]+)?", "0.00")
                .ReReplace("PER (\\w+)", "every $1", RegexOptions.IgnoreCase).Should().Be("Cost of $0.00 every week.");
        }

        [TestMethod]
        public void JoinTest()
        {
            var strList = new List<string>(new string[] { "one", "two", "three" });

            strList.Join(",").Should().Be("one,two,three");
        }
    }
}
