namespace TextAnalyzer.BusinessLogic
{
    public interface IPatternCounter : ISymbolCounter
    {
        string MatchMemory { get; }
    }
}