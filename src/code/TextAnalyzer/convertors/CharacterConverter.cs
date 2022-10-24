namespace TextAnalyzer
{
    using System.Collections.Generic;

    public class CharacterConverter : ICharacterConverter
    {
        public CharacterConverter()
        {
            Modificators = new List<ICharacterModificator>();
        }

        public IList<ICharacterModificator> Modificators { get; private set; }

        public char? Convert(char character)
        {
            char? resultChar = character;

            foreach (var modificator in Modificators)
            {
                resultChar = modificator.Modify(character);
                if (resultChar == null)
                {
                    return null;
                }
            }

            return resultChar;
        }
    }
}