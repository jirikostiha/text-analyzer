namespace TextAnalyzer.Exceptions
{
    using System;
    using UI.helpers;

    public class ProductionExceptionHandler : IExceptionHandler
    {
        public void HandleException(object sender, Exception exception)
        {
            DialogHelper.ShowErrorMessage(exception.Message);
        }

        public void HandleAsException(object sender, object exception)
        {
            throw new NotImplementedException();
        }

        public void HandleUnhandledException(object sender, Exception exception)
        {
            var message = string.Format("{0}\n\nDetails:\n{1}",
                Properties.Resources.errUnknownError,
                exception.Message);

            DialogHelper.ShowUnhandledExceptionMessage(message);
        }
    }
}