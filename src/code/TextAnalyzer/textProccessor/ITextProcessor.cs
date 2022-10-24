namespace TextAnalyzer
{
    public interface ITextProcessor
    {
        IContinousAnalyzer Analyzer { get; set; }
        ICharacterConverter Converter { get; set; }

        string Process(string data);
    }
}
