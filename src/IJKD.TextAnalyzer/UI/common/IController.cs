namespace IJKD.TextAnalyzer.UI
{
    public interface IController<out TView>
    {
        TView View { get; }
    }
}