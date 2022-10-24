namespace TextAnalyzer
{
    using System;
    using System.Linq;

    /// <summary>
    /// Value code contract.
    /// </summary>
    public static class ValueContract
    {
        /// <summary>
        /// Action key.
        /// </summary>
        private const string ActionKey = "Action";

        /// <summary>
        /// Additional key.
        /// </summary>
        private const string AdditionalInfoKey = "AdditionalInfo";

        /// <summary>
        /// Value key.
        /// </summary>
        private const string ValueKey = "Value";

        /// <summary>
        /// Contract guarding an class instance value is not null.
        /// </summary>
        /// <typeparam name="T"> The value type. </typeparam>
        /// <param name="value"> The value. </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static T NotNull<T>(this T value, string? additionalInfo = null)
            where T : class 
        {
            if (value == null)
            {
                var e = new ArgumentNullException(nameof(value), "Class instance parameter is null.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding a nullable value is not null.
        /// </summary>
        /// <typeparam name="T"> The nullable value type. </typeparam>
        /// <param name="value"> The nullable value. </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static T? NotNull<T>(this T? value, string? additionalInfo = null) 
            where T : struct
        {
            if (value == null)
            {
                var e = new ArgumentNullException(nameof(value), "Nullable instance parameter is null.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding a <see cref="Guid"/> value is not equal to <see cref="Guid.Empty"/>.
        /// </summary>
        /// <param name="value"> The guid value. </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static Guid NotEmpty(this Guid value, string? additionalInfo = null)
        {
            if (value == Guid.Empty)
            {
                var e = new ArgumentOutOfRangeException(nameof(value), "Guid parameter value is empty.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding an comparable value is greater than other value.
        /// </summary>
        /// <typeparam name="T"> The value type. </typeparam>
        /// <param name="value"> The value. </param>
        /// <param name="other"> The other value.  </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static T GreaterThan<T>(this T value, T other, string? additionalInfo = null)
            where T : IComparable<T>
        {
            if (value.CompareTo(other) < 0)
            {
                var e = new ArgumentOutOfRangeException(nameof(value), value, $"Parameter value is less or equal to comparing value '{other}'.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding an comparable value is greater or equal to other value.
        /// </summary>
        /// <typeparam name="T"> The value type. </typeparam>
        /// <param name="value"> The value. </param>
        /// <param name="other"> The other value.  </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static T GreaterOrEqualTo<T>(this T value, T other, string? additionalInfo = null)
            where T : IComparable<T>
        {
            if (value.CompareTo(other) < 0)
            {
                var e = new ArgumentOutOfRangeException(nameof(value), value, $"Parameter value is less than comparing value '{other}'.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding an comparable value is greater than other value.
        /// </summary>
        /// <typeparam name="T"> The value type. </typeparam>
        /// <param name="value"> The value. </param>
        /// <param name="other"> The other value.  </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static T LessThan<T>(this T value, T other, string? additionalInfo = null)
            where T : IComparable<T>
        {
            if (value.CompareTo(other) >= 0)
            {
                var e = new ArgumentOutOfRangeException(nameof(value), value, $"Parameter value is greater or equal to comparing value '{other}'.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding a string value is not equal to <see cref="string.Empty"/>.
        /// </summary>
        /// <param name="value"> The string value. </param>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <returns> The input value. </returns>
        public static string NotEmpty(this string value, string? additionalInfo = null)
        {
            if (value == string.Empty)
            {
                var e = new ArgumentOutOfRangeException(nameof(value), "String parameter value is empty.");
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }

        /// <summary>
        /// Contract guarding a string value does not contain any whitespace character.
        /// </summary>
        /// <param name="value"> The string value. </param>
        /// <returns> The input value. </returns>
        /// <param name="additionalInfo"> An additional information. </param>
        /// <remarks>
        /// White space characters: http://msdn.microsoft.com/en-us/library/t809ektx.aspx
        /// </remarks>
        public static string NotContainsWhitespace(this string value, string? additionalInfo = null)
        {
            if (value.Any(char.IsWhiteSpace))
            {
                var e = new ArgumentException("String parameter value contains at least one whitespace character.", nameof(value));
                e.Data.Add(ActionKey, "Evaluating value code contract.");
                e.Data.Add(ValueKey, value);
                if (additionalInfo != null)
                {
                    e.Data.Add(AdditionalInfoKey, additionalInfo);
                }

                throw e;
            }

            return value;
        }
    }
}