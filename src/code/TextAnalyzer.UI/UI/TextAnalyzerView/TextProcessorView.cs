namespace TextAnalyzer.UI.TextAnalyzerView
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class TextProcessorView : Form, ITextProcessorView
    {
        private const int MaxProgressValue = 100;

        #region ctors
        public TextProcessorView(TextProcessorController controller)
        {
            //controller.NotNull();

            controller.View = this;
            Controller = controller;
            InitializeComponent();
            Reset();
        }
        #endregion

        public TextProcessorController Controller { get; private set; }

        #region Methods - public
        public void Refresh(int percentage, AnalysisResult result)
        {
            pbProgress.Value = percentage;
            ShowAnalyzedDataCounters(result);

            if (percentage >= 100)
            {
                // handle finish state
                lblStatus.Text = Resources.infoFinished;
                pbProgress.Value = percentage;
                ShowFinalAnalysisResult(result);

                btnRun.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        public void WorkStopped()
        {
            lblStatus.Text = Resources.infoStopped;
            btnRun.Enabled = true;
            Reset();
        }
        #endregion

        #region Event handlers - controls
        private void btnInpputFileBrowse_Click(object sender, EventArgs e)
        {
            ofdOpenInputFile.FileName = tbInputFilePath.Text;
            DialogResult result = ofdOpenInputFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbInputFilePath.Text = ofdOpenInputFile.FileName;
            }
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            btnStop.Enabled = true;

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
        private void ShowFinalAnalysisResult(AnalysisResult result)
        {
            ShowAnalyzedDataCounters(result);
        }

        private void ShowAnalyzedDataCounters(AnalysisResult result)
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