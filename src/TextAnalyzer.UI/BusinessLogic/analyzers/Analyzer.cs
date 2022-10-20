namespace IJKD.TextAnalyzer.BusinessLogic
{
    /// <summary>
    /// Responsible for text analysis.
    /// </summary>
    public class Analyzer : IContinousAnalyzer
    {
        public Analyzer()
        {
            Reset();
        }

        public PrintableCharCounter PrintableCharCounter { get; set; }
        public LineBreakCounter LineBreakCounter { get; set; }
        public WordCounter WordCounter { get; set; }
        public SentenceCounter SentenceCounter { get; set; }

        /// <summary>
        /// Returns a result of analysis.
        /// </summary>
        public AnalysisResult GetResult()
        {
            return new AnalysisResult()
                {
                    CharCount = PrintableCharCounter.Count,
                    LineBreakCount = LineBreakCounter.Count,
                    WordCount = WordCounter.Count,
                    SentenceCount = SentenceCounter.Count
                };
        }

        /// <summary>
        /// Analyze character.
        /// </summary>
        /// <param name="character"></param>
        public void Analyze(char character)
        {
            PrintableCharCounter.Analyze(character);
            LineBreakCounter.Analyze(character);
            WordCounter.Analyze(character);
            SentenceCounter.Analyze(character);
        }

        public void Reset()
        {
            if (PrintableCharCounter != null) PrintableCharCounter.Reset();
            if (LineBreakCounter != null) LineBreakCounter.Reset();
            if (WordCounter != null) WordCounter.Reset();
            if (SentenceCounter != null) SentenceCounter.Reset();
        }
    }
}