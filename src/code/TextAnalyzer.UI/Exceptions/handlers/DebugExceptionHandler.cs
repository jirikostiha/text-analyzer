namespace TextAnalyzer.UI.Exceptions
{
    using System;
    using TextAnalyzer.Exceptions;

    public class DebugExceptionHandler : IExceptionHandler
    {
        public void HandleException(object sender, Exception exception)
        {
            var formatter = new ExceptionFormatter();
            var message = formatter.Format(exception);

            DialogHelper.ShowErrorMessage(message);
        }

        public void HandleAsException(object sender, object exception)
        {
            throw new NotImplementedException();
        }

        public void HandleUnhandledException(object sender, Exception exception)
        {
            var formatter = new ExceptionFormatter();
            var formattedException = formatter.Format(exception);
            var message = string.Format("{0}\n\nDetails:\n{1}", 
                Resources.errUnknownError, 
                formattedException);

            DialogHelper.ShowUnhandledExceptionMessage(message);
        }
    }
}