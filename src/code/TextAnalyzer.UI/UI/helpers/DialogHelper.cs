namespace TextAnalyzer.UI.helpers
{
    using System.Windows.Forms;

    internal static class DialogHelper
  {
      public static void ShowErrorMessage(string message)
      {
          MessageBox.Show(message, Properties.Resources.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public static void ShowUnhandledExceptionMessage(string message)
      {
          MessageBox.Show(message, Properties.Resources.titleUnhandledException, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public static void ShowInfoMessage(string message)
      {
          MessageBox.Show(message, Properties.Resources.titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      public static void ShowWarningMessage(string message)
      {
          MessageBox.Show(message, Properties.Resources.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      public static DialogResult ShowYesNoWarningMessage(string message, MessageBoxDefaultButton defaultButton)
      {
          return MessageBox.Show(message, Properties.Resources.titleWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton);
      }

      public static DialogResult ShowYesNoQuestionMessage(string message)
      {
          return MessageBox.Show(message, Properties.Resources.titleQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      }
  }
}