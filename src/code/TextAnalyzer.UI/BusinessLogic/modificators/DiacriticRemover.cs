namespace TextAnalyzer.BusinessLogic
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Responsible for removing a diacritics.
    /// </summary>
    public class DiacriticRemover : ICharacterModificator
    {
        /// <summary>
        /// Removes diacritism.
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public char? Modify(char character)
        {
            string normalizedD = character.ToString().Normalize(NormalizationForm.FormD);
            for (int index = 0; index < normalizedD.Length; index++)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(normalizedD[index]) != UnicodeCategory.NonSpacingMark)
                    return normalizedD[index];
            }
            return character;
        }
    }
}