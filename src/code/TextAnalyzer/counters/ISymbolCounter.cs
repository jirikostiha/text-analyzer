namespace TextAnalyzer.BusinessLogic
{
    public interface ISymbolCounter : IResetable
    {
        int Count { get; }
        void Analyze(char character);
    }
}