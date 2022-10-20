namespace IJKD.TextAnalyzer.Test
{
    using BusinessLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class SentenseCounterTest
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

        private void AnalyzeString(SentenceCounter sentenceCounter, string str)
        {
            foreach (char c in str)
            {
                sentenceCounter.Analyze(c);
            }
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromWordsOnly_StringIsMemorized()
        {
            SentenceCounter target = new SentenceCounter();
            string str = "ahoj svete";

            AnalyzeString(target, str);
            
           Assert.AreEqual(str, target.MatchMemory);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringFromWordsOnly_CounterUnchanged()
        {
            SentenceCounter target = new SentenceCounter();
            string str = "ahoj svete";

            AnalyzeString(target, str);

            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringAsSentenceEndedByDot_CounterIncreased()
        {
            SentenceCounter target = new SentenceCounter();
            string str = "Ahoj svete.";

            AnalyzeString(target, str);

            Assert.AreEqual(1, target.Count);
        }


        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_StringAsSentenceEndedByDot_MemoryFlushed()
        {
            SentenceCounter target = new SentenceCounter();
            string str = "Ahoj svete.";

            AnalyzeString(target, str);

            Assert.AreEqual(string.Empty, target.MatchMemory);
        }
    }
}
