namespace TextAnalyzer.BusinessLogic
{
    public class AnalysisResult
    {
        public int CharCount { get; set; }

        public int WordCount { get; set; }

        public int LineBreakCount { get; set; }

        public int LineCount
        {
            get { return CharCount == 0 && LineBreakCount == 0 ? 0 : LineBreakCount + 1; }
        }

        public int SentenceCount { get; set; }
    }
}