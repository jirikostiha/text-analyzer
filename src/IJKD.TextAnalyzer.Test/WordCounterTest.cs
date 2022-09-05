namespace IJKD.TextAnalyzer.Test
{
    using BusinessLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class WordCounterTest
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

        private void AnalyzeString(WordCounter wordCounter, string str)
        {
            foreach (char c in str)
            {
                wordCounter.Analyze(c);
            }
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromAlphabeticSymbolsOnly_StringIsMemorized()
        {
            WordCounter target = new WordCounter();
            string str = "ahoj";

            AnalyzeString(target, str);
            
            Assert.AreEqual(str, target.MatchMemory);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromAlphabeticSymbolsOnly_CounterUnchanged()
        {
            WordCounter target = new WordCounter();
            string str = "ahoj";

            AnalyzeString(target, str);

            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromAlphabeticSymbolsEndedBySpace_CounterIncreased()
        {
            WordCounter target = new WordCounter();
            string str = "ahoj ";

            AnalyzeString(target, str);

            Assert.AreEqual(1, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromAlphabeticSymbolsEndedBySpace_MemoryFlushed()
        {
            WordCounter target = new WordCounter();
            string str = "ahoj ";

            AnalyzeString(target, str);

            Assert.AreEqual(string.Empty, target.MatchMemory);
        }
    }
}
