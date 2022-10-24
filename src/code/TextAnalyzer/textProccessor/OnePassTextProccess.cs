namespace TextAnalyzer
{
    using System.Text;

    public class OnePassTextProcessor : ITextProcessor, IResetable
    {
        private StringBuilder? _builder;

        public OnePassTextProcessor()
        {
            Reset();
        }

        public IContinousAnalyzer Analyzer { get; set; }
        public ICharacterConverter Converter { get; set; }

        public string Process(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            _builder = new StringBuilder(data.Length);

            foreach (var character in data)
            {
                if (Analyzer != null)
                {
                    // perform analysis
                    Analyzer.Analyze(character);
                }

                if (Converter != null)
                {
                    // perform conversion
                    var convertedChar = Converter.Convert(character);
                    if (convertedChar != null)
                    {
                        _builder.Append(convertedChar);
                    }
                }
            }

            return _builder.ToString();
        }

        public void Reset()
        {
            if (Analyzer != null) Analyzer.Reset();
            _builder = null;
        }

        #region static

        public static OnePassTextProcessor Create(OnePassTextProcessorOptions options)
        {
            var analyzer = new Analyzer();
            if (options.Analysis is not null)
            {
                if (options.Analysis.CountLineBreaks)
                    analyzer.LineBreakCounter = new LineBreakCounter();

                if (options.Analysis.CountPrintableChars)
                    analyzer.PrintableCharCounter = new PrintableCharCounter();

                if (options.Analysis.CountWords)
                    analyzer.WordCounter = new WordCounter();

                if (options.Analysis.CountSentence)
                    analyzer.SentenceCounter = new SentenceCounter();
            }

            var converter = new CharacterConverter();
            if (options.Modifications is not null)
            {
                if (options.Modifications.RemovePunctation)
                    converter.Modificators.Add(new PunctationRemover());

                if (options.Modifications.RemoveEmptyLines)
                    converter.Modificators.Add(new EmptyLineRemover());

                if (options.Modifications.RemoveDiacritic)
                    converter.Modificators.Add(new DiacriticRemover());

                if (options.Modifications.RemoveSpaces)
                    converter.Modificators.Add(new SpaceRemover());
            }

            var processor = new OnePassTextProcessor()
            {
                Analyzer = analyzer,
                Converter = converter
            };

            return processor;
        }

        #endregion
    }
}