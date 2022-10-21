namespace TextAnalyzer.UI
{
    public interface IView<out TController>
    {
        TController Controller { get; }
    }
}