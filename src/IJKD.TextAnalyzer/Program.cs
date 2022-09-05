namespace IJKD.TextAnalyzer
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using Exceptions;
    using UI.TextAnalyzerView;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TextProcessorView(new TextProcessorController()));
        }

        /// <summary>
        /// Handles unhandled exceptions for current domain.
        /// </summary>
        /// <param name="sender">A sender object.</param>
        /// <param name="e">An event arguments.</param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                if (ex is UIException)
                {
                    ExceptionHelper.ResolveAndHandle(sender, ex);
                }
                else
                {
                    ExceptionHelper.ResolveAndHandleUnhandled(sender, ex);
                }
            }
            else
            {
                ExceptionHelper.ResolveAndHandle(sender, e.ExceptionObject);    
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is UIException)
            {
                ExceptionHelper.ResolveAndHandle(sender, e.Exception);
            }
            else
            {
                ExceptionHelper.ResolveAndHandleUnhandled(sender, e.Exception);
            }
        }

        /// <summary>
        /// Handles process exit event for current domain.
        /// Occurs when the default application domain's parent process exits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
        }
    }
}
