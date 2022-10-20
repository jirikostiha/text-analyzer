namespace IJKD.TextAnalyzer.BusinessLogic
{
    public interface IContinousAnalyzer : IResetable
    {
        AnalysisResult GetResult();
        void Analyze(char character);
    }
}
