namespace IJKD.TextAnalyzer
{
    public static class StringExtension
    {
        public static string TryGetSubstring(this string str, int startIndex, int maxLength)
        {
            if (str == null) { return null; }
            if (str.Length <= startIndex + maxLength) { return string.Empty; }
        
            var length = (str.Length - startIndex) > maxLength ? maxLength : str.Length - startIndex;
            return str.Substring(startIndex, length);
        }
    }
}