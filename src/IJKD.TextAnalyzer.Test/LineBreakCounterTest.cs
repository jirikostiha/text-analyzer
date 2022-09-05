namespace IJKD.TextAnalyzer.Test
{
    using BusinessLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class LineBreakCounterTest
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

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_EndOfLineSymbol_CounterIncreased()
        {
            LineBreakCounter target = new LineBreakCounter();
            char character = '\n';

            target.Analyze(character);
            
            Assert.AreEqual(1, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_AlphabetSymbol_CounterUnchanged()
        {
            LineBreakCounter target = new LineBreakCounter();
            char character = 'a';

            target.Analyze(character);

            Assert.AreEqual(0, target.Count);
        }

        //dalsi unit testy

    }
}
