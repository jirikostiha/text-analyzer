namespace TextAnalyzer
{
    public interface IPatternCounter : ISymbolCounter
    {
        string MatchMemory { get; }
    }
}