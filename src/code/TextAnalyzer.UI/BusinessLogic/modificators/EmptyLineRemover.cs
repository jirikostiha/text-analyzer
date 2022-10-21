namespace TextAnalyzer.BusinessLogic
{
    /// <summary>
    /// Responsible for removing empty lines.
    /// </summary>
    public class EmptyLineRemover : ICharacterModificator
    {
        private const char DefaultLineSeparator = '\n';

        public EmptyLineRemover()
        {
            IsEmptyLine = true;
            LineSeparator = DefaultLineSeparator;
        }

        /// <summary>
        /// Indicates if was non white space character since last line separator.
        /// </summary>
        public bool IsEmptyLine { get; private set; }

        public char LineSeparator { get; set; }

        public char? Modify(char character)
        {
            if (character == LineSeparator)
            {
                if (IsEmptyLine)
                {
                    return null;    
                }
                else
                {
                    IsEmptyLine = true;
                }
            }
            if (!char.IsWhiteSpace(character))
            {
                IsEmptyLine = false;
            }

            return character;
        }
    }
}