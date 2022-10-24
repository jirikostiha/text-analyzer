namespace TextAnalyzer.UI.TextAnalyzerView
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    public partial class TextProcessorView : Form, ITextProcessorView
    {
        private const int MaxProgressValue = 100;

        #region ctors
        public TextProcessorView(TextProcessorController controller)
        {
            controller.NotNull();

            controller.View = this;
            Controller = controller;
            InitializeComponent();
            Reset();
            RefreshControllingControls();
        }
        #endregion

        public TextProcessorController Controller { get; private set; }

        public void Refresh(int percentage, AnalysisResult result)
        {
            pbProgress.Value = percentage;
            if (result == null) // in case of no inputs
            {
                RefreshControllingControls();

                return;
            }

            ShowAnalysisResults(result);

            if (percentage >= 100)
            {
                // handle finish state
                lblStatus.Text = Resources.infoFinished;
                pbProgress.Value = percentage;
                ShowFinalAnalysisResult(result);
                RefreshControllingControls();
            }
        }

        public void WorkStopped()
        {
            lblStatus.Text = Resources.infoStopped;
            btnRun.Enabled = true;
            Reset();
            RefreshControllingControls();
        }

        #region Event handlers - controls
        private void btnInpputFileBrowse_Click(object sender, EventArgs e)
        {
            ofdOpenInputFile.FileName = tbInputFilePath.Text;
            DialogResult result = ofdOpenInputFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbInputFilePath.Text = ofdOpenInputFile.FileName;
                if (string.IsNullOrEmpty(tbOutputFilePath.Text))
                {
                    var sugestedOutputFilePath = Path.Combine(
                        Path.GetDirectoryName(tbInputFilePath.Text),
                        Path.GetFileNameWithoutExtension(ofdOpenInputFile.FileName) + "_output");
                    sugestedOutputFilePath += $".{Path.GetExtension(ofdOpenInputFile.FileName)}";
                    
                    tbOutputFilePath.Text = sugestedOutputFilePath;
                }
            }
        }

        private void tbInputFilePath_TextChanged(object sender, EventArgs e)
        {
            RefreshControllingControls();
        }

        private void btnOutputFileBrowse_Click(object sender, EventArgs e)
        {
            ofdOpenInputFile.FileName = tbOutputFilePath.Text;
            DialogResult result = ofdOpenOutputFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputFilePath.Text = ofdOpenOutputFile.FileName;
            }
        }

        private void tbOutputFilePath_TextChanged(object sender, EventArgs e)
        {
            RefreshControllingControls();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RefreshControllingControls(true);

            Reset();
            lblStatus.Text = Resources.infoAnalyzing;

            Controller.Run(tbInputFilePath.Text, tbOutputFilePath.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Controller.Stop();
        }
        #endregion

        #region Methods - private

        private void RefreshControllingControls(bool running = false)
        {
            tbInputFilePath.Enabled = !running;
            btnInputFileBrowse.Enabled = !running;
            tbOutputFilePath.Enabled = !running;
            btnOutputFileBrowse.Enabled = !running;

            btnRun.Enabled =
                !running
                && !string.IsNullOrEmpty(tbInputFilePath.Text)
                && !string.IsNullOrEmpty(tbOutputFilePath.Text);

            btnStop.Enabled = running;
        }

        private void ShowFinalAnalysisResult(AnalysisResult result)
        {
            ShowAnalysisResults(result);
        }

        private void ShowAnalysisResults(AnalysisResult result)
        {
            lblChars.Text = result.CharCount.ToString(CultureInfo.InvariantCulture);
            lblWords.Text = result.WordCount.ToString(CultureInfo.InvariantCulture);
            lblLines.Text = result.LineCount.ToString(CultureInfo.InvariantCulture);
            lblSentences.Text = result.SentenceCount.ToString(CultureInfo.InvariantCulture);
        }

        private void Reset()
        {
            ResetProgressBar();
            ResetResultLabels();
        }

        private void ResetResultLabels()
        {
            lblChars.Text = "0";
            lblWords.Text = "0";
            lblLines.Text = "0";
            lblSentences.Text = "0";
        }

        private void ResetProgressBar()
        {
            pbProgress.Minimum = 0;
            pbProgress.Maximum = MaxProgressValue;
            pbProgress.Value = 0;
        }
        #endregion
    }
}