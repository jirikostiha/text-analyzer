namespace IJKD.TextAnalyzer.BusinessLogic
{
    public interface ITextProcessor
    {
        IContinousAnalyzer Analyzer { get; set; }
        ICharacterConverter Converter { get; set; }

        string Process(string data);
    }
}
