namespace TextAnalyzer
{
    public class WordCounter : IPatternCounter
    {
        public WordCounter()
        {
            Reset();
        }

        public int Count { get; private set; }
        
        public string MatchMemory { get; private set; }

        public void Analyze(char character)
        {
            if (char.IsLetterOrDigit(character))
            {
                MatchMemory += character;
            }
            else
            {
                MarkMatchEnd();
            }
        }

        private void MarkMatchEnd()
        {
            if (!string.IsNullOrEmpty(MatchMemory))
            {
                Count++;
            }
            MatchMemory = string.Empty;
        }

        public void Reset()
        {
            Count = 0;
            MatchMemory = string.Empty;
        }
    }
}