namespace TextAnalyzer
{
    public class DigitCounter : ISymbolCounter
    {
        public DigitCounter()
        {
            Reset();
        }

        public int Count { get; private set; }

        public void Analyze(char character)
        {
            if (char.IsDigit(character))
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