namespace TextAnalyzer.UI
{
    using System.Windows.Forms;

    internal static class DialogHelper
  {
      public static void ShowErrorMessage(string message)
      {
          MessageBox.Show(message, Resources.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public static void ShowUnhandledExceptionMessage(string message)
      {
          MessageBox.Show(message, Resources.titleUnhandledException, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public static void ShowInfoMessage(string message)
      {
          MessageBox.Show(message, Resources.titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      public static void ShowWarningMessage(string message)
      {
          MessageBox.Show(message, Resources.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      public static DialogResult ShowYesNoWarningMessage(string message, MessageBoxDefaultButton defaultButton)
      {
          return MessageBox.Show(message, Resources.titleWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
      }

      public static DialogResult ShowYesNoQuestionMessage(string message)
      {
          return MessageBox.Show(message, Resources.titleQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      }
  }
}