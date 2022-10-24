namespace TextAnalyzer.UI.Exceptions
{
    using System;

    public class UIException : SystemException
    {
        #region Constructors
        public UIException()
            : base()
        { }

        public UIException(string message)
            : base(message)
        {
        }

        public UIException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        #endregion
    }
}