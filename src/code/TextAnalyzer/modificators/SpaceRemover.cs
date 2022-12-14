namespace TextAnalyzer
{
    using System.Globalization;

    /// <summary>
    /// Removes spaces and returns CameCased words.
    /// </summary>
    public class SpaceRemover : ICharacterModificator
    {
        /// <summary>
        /// Indicates if last character was alphabet char or digit.
        /// </summary>
        public bool WasLetterOrDigit { get; private set; }

        public char? Modify(char character)
        {
            if (character == ' ')
            {
                WasLetterOrDigit = false;
                return null;
            }
            else
            {
                if (char.IsLetterOrDigit(character))
                {
                    if (WasLetterOrDigit)
                    {
                        WasLetterOrDigit = true;
                        return char.ToLower(character, CultureInfo.CurrentUICulture);
                    }
                    else
                    {
                        WasLetterOrDigit = true;
                        return char.ToUpper(character, CultureInfo.CurrentUICulture);
                    }
                }
            }

            return character;
        }
    }
}