namespace IJKD.TextAnalyzer.Test
{
    using BusinessLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class LetterCounterTest
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
        public void Analyze_AlphabetLetter_CounterIncreased()
        {
            PrintableCharCounter target = new PrintableCharCounter();
            char character = 'a';
            
            target.Analyze(character);

            Assert.AreEqual(1, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_Digit_CounterIncreased()
        {
            PrintableCharCounter target = new PrintableCharCounter();
            char character = '4';

            target.Analyze(character);

            Assert.AreEqual(1, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_TabSymbol_CounterUnchanged()
        {
            PrintableCharCounter target = new PrintableCharCounter();
            char character = '\t';

            target.Analyze(character);

            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_Space_CounterUnchanged()
        {
            PrintableCharCounter target = new PrintableCharCounter();
            char character = ' ';

            target.Analyze(character);

            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        ///A test for Analyze
        ///</summary>
        [TestMethod()]
        public void Analyze_EndOfLineSymbol_CounterUnchanged()
        {
            PrintableCharCounter target = new PrintableCharCounter();
            char character = '\n';

            target.Analyze(character);

            Assert.AreEqual(0, target.Count);
        }

        //dalsi unit testy
    }
}