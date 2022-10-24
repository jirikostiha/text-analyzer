namespace TextAnalyzer.UI
{
    public class Global
    {
        #if DEBUG
        public const bool IsInDebugMode = true;
        #else
        public const bool IsInDebugMode = false;
        #endif


    }
}