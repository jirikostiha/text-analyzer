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
    }
}