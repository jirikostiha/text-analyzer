namespace IJKD.TextAnalyzer.Exceptions
{
    using System;

    public interface IExceptionHandler
    {
        void HandleException(object sender, Exception exception);
        void HandleAsException(object sender, object exception);
        void HandleUnhandledException(object sender, Exception exception);
    }
}