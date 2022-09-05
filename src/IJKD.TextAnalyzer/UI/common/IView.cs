namespace IJKD.TextAnalyzer.UI
{
    public interface IView<out TController>
    {
        TController Controller { get; }
    }
}