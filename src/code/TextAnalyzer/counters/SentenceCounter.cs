namespace TextAnalyzer
{
    using System.Globalization;

    public class SentenceCounter : IPatternCounter
    {
        public SentenceCounter()
        {
            SentenceBreaks = Text.SentenceEndCharacters;
            Reset();
        }

        public string SentenceBreaks { get; private set; }

        public int Count { get; private set; }
        
        public string MatchMemory { get; private set; }

        public void Analyze(char character)
        {
            if (!SentenceBreaks.Contains(character.ToString(CultureInfo.InvariantCulture)))
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