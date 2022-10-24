namespace TextAnalyzer.Test
{
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class SpaceRemoverTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private string ModifyString(SpaceRemover spaceRemover, string str)
        {
            var sb = new StringBuilder();

            foreach (char c in str)
            {
                var newChar = spaceRemover.Modify(c);
                if (newChar != null)
                {
                    sb.Append(newChar);
                }
            }

            return sb.ToString();
        }

        [TestMethod()]
        public void Modify_StringWithSpacesOnly_NullOrEmptyString()
        {
            var target = new SpaceRemover();
            var input = "   ";
            string expected = "";

            string actual = ModifyString(target, input);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Modify_StringWithWordsDevidedBySpaces_WordsOnly()
        {
            var target = new SpaceRemover();
            var input = "programovani je zabava";
            string expected = "ProgramovaniJeZabava";

            string actual = ModifyString(target, input);

            Assert.AreEqual(expected, actual);
        }
    }
}
