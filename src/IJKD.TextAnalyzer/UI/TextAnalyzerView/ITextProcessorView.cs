namespace IJKD.TextAnalyzer.UI.TextAnalyzerView
{
    using BusinessLogic;

    public interface ITextProcessorView : IView<TextProcessorController>
    {
        void Refresh(int progressPercent, AnalysisResult result);
        void WorkStopped();
    }
}