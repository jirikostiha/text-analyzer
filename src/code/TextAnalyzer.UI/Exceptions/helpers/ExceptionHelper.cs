namespace TextAnalyzer.UI.Exceptions
{
    using System;

    internal static class ExceptionHelper
    {
        public static IExceptionHandler ResolveExceptionHandler()
        {
            if (Global.IsInDebugMode)
            {
                return new DebugExceptionHandler();
            }
            else
            {
                return new ProductionExceptionHandler();
            }
        }

        public static void ResolveAndHandle(object sender, Exception exception)
        {
            ResolveExceptionHandler().HandleException(sender, exception);
        }

        public static void ResolveAndHandle(object sender, object exceptionObjekt)
        {
            ResolveExceptionHandler().HandleAsException(sender, exceptionObjekt);
        }

        public static void ResolveAndHandleUnhandled(object sender, Exception exception)
        {
            ResolveExceptionHandler().HandleUnhandledException(sender, exception);
        }
    }
}