namespace TextAnalyzer.BusinessLogic
{
    public class LineBreakCounter : ISymbolCounter
    {
        private const char DefaultLineSeparator = '\n';

        public LineBreakCounter()
        {
            LineBreakSymbol = DefaultLineSeparator;
            Reset();
        }

        public char LineBreakSymbol { get; set; }

        public int Count { get; private set; }

        public void Analyze(char character)
        {
            if (character == LineBreakSymbol)
            {
                Count++;
            }
        }

        public void Reset()
        {
            Count = 0;
        }
    }
}