namespace TextAnalyzer.BusinessLogic
{
    /// <summary>
    /// Converts punctation to spaces.
    /// </summary>
    public class PunctationRemover : ICharacterModificator
    {
        public char? Modify(char character)
        {
            if (char.IsPunctuation(character))
            {
                return ' ';
            }

            return character;
        }
    }
}