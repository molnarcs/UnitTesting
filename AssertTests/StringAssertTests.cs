using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AssertTests
{
    [TestClass]
    public class StringAssertTests
    {
        [TestMethod]
        public void ContainsTest()
        {
            string find = "test";
            string text = "This is a test text";

            StringAssert.Contains(text, find, "A szöveg nem tartalmazza a keresettet!");
        }

        [TestMethod]
        public void MatchesTest()
        {
            Regex regex = new Regex("[0-9]");
            string testString = "This is first 2 test for Regex";

            StringAssert.Matches(testString, regex, "Nincsenek számok {0} és {1} között a szövegben!", 0, 9);
        }

        [TestMethod]
        public void DoesNotMatchTest()
        {
            Regex regex = new Regex("[0-9]");
            string testString = "This is second test for Regex";

            StringAssert.DoesNotMatch(testString, regex, "Vannak számok {0} és {1} között a szövegben!", 0, 9);
        }

        [TestMethod]
        public void StartsWithTest()
        {
            string find = "test";
            string text = "test This is a test text";

            StringAssert.StartsWith(text, find, "A szöveg nem a megadott szöveggel kezdődik!");
        }

        [TestMethod]
        public void EndsWithTest()
        {
            string find = "test";
            string text = "This is a test text";

            StringAssert.EndsWith(text, find, "A szöveg nem a megadott szöveggel végződik!");
        }
    }
}
