namespace TextAnalyzer.UI.TextAnalyzerView
{
    public interface ITextProcessorView : IView<TextProcessorController>
    {
        void Refresh(int progressPercent, AnalysisResult result);
        void WorkStopped();
    }
}