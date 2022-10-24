namespace TextAnalyzer
{
    public interface ISymbolCounter : IResetable
    {
        int Count { get; }
        void Analyze(char character);
    }
}