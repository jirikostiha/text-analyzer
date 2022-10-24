namespace TextAnalyzer
{
    public interface IContinousAnalyzer : IResetable
    {
        AnalysisResult GetResult();
        void Analyze(char character);
    }
}
