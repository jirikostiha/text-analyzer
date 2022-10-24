namespace TextAnalyzer
{
    public class PrintableCharCounter : ISymbolCounter
    {
        public PrintableCharCounter()
        {
            Reset();
        }

        public int Count { get; private set; }

        public void Analyze(char character)
        {
            if (!char.IsWhiteSpace(character))
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