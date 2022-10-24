namespace TextAnalyzer
{
    public record OnePassTextProcessorOptions
    {
        public AnalysisOptions Analysis { get; set; }
        public ModificationOptions Modifications { get; set; }
    }

    public record AnalysisOptions
    {
        public bool CountLineBreaks { get; set; }
        public bool CountPrintableChars { get; set; }
        public bool CountWords { get; set; }
        public bool CountSentence { get; set; }

        public static AnalysisOptions All => new()
        {
            CountLineBreaks = true,
            CountPrintableChars = true,
            CountWords = true,
            CountSentence = true
        };

        public static AnalysisOptions None => new()
        {
            CountLineBreaks = false,
            CountPrintableChars = false,
            CountWords = false,
            CountSentence = false
        };
    }

    public record ModificationOptions
    {
        public bool RemoveSpaces { get; set; }
        public bool RemoveEmptyLines { get; set; }
        public bool RemoveDiacritic { get; set; }
        public bool RemovePunctation { get; set; }
        
        public static ModificationOptions All => new()
        {
            RemoveEmptyLines = true,
            RemoveSpaces = true,
            RemoveDiacritic = true,
            RemovePunctation = true
        };

        public static ModificationOptions None => new()
        {
            RemoveEmptyLines = false,
            RemoveSpaces = false,
            RemoveDiacritic = false,
            RemovePunctation = false
        };
    }
}