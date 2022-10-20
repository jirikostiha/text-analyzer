namespace IJKD.TextAnalyzer.UI.TextAnalyzerView
{
    partial class TextProcessorView : ITextProcessorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextProcessorView));
            this.btnInputFileBrowse = new System.Windows.Forms.Button();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.tbInputFilePath = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.ofdOpenInputFile = new System.Windows.Forms.OpenFileDialog();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.tbOutputFilePath = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.btnOutputFileBrowse = new System.Windows.Forms.Button();
            this.pnlControling = new System.Windows.Forms.Panel();
            this.tblControlingButtons = new System.Windows.Forms.TableLayoutPanel();
            this.lblChars = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblSentNum = new System.Windows.Forms.Label();
            this.lblWordNum = new System.Windows.Forms.Label();
            this.lblLineNum = new System.Windows.Forms.Label();
            this.lblCharNum = new System.Windows.Forms.Label();
            this.ofdOpenOutputFile = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ssStatus.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlControling.SuspendLayout();
            this.tblControlingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInputFileBrowse
            // 
            this.btnInputFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputFileBrowse.Location = new System.Drawing.Point(525, 9);
            this.btnInputFileBrowse.Name = "btnInputFileBrowse";
            this.btnInputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnInputFileBrowse.TabIndex = 20;
            this.btnInputFileBrowse.Text = "Browse";
            this.btnInputFileBrowse.UseVisualStyleBackColor = true;
            this.btnInputFileBrowse.Click += new System.EventHandler(this.btnInpputFileBrowse_Click);
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(9, 14);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(50, 13);
            this.lblInputFile.TabIndex = 1;
            this.lblInputFile.Text = "Input file:";
            // 
            // tbInputFilePath
            // 
            this.tbInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputFilePath.Location = new System.Drawing.Point(73, 12);
            this.tbInputFilePath.Name = "tbInputFilePath";
            this.tbInputFilePath.Size = new System.Drawing.Size(446, 20);
            this.tbInputFilePath.TabIndex = 10;
            this.ToolTip.SetToolTip(this.tbInputFilePath, "Speify text file you want to proccess.");
            // 
            // btnRun
            // 
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRun.BackgroundImage")));
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRun.Location = new System.Drawing.Point(203, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 50);
            this.btnRun.TabIndex = 50;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // ofdOpenInputFile
            // 
            this.ofdOpenInputFile.Filter = "Text File (*.txt)|*.txt";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbProgress});
            this.ssStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ssStatus.Location = new System.Drawing.Point(0, 270);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(612, 22);
            this.ssStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "-------";
            // 
            // pbProgress
            // 
            this.pbProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(200, 16);
            this.pbProgress.Step = 1;
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(309, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.TabIndex = 60;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.tbOutputFilePath);
            this.pnlInput.Controls.Add(this.lblOutputFile);
            this.pnlInput.Controls.Add(this.btnOutputFileBrowse);
            this.pnlInput.Controls.Add(this.tbInputFilePath);
            this.pnlInput.Controls.Add(this.lblInputFile);
            this.pnlInput.Controls.Add(this.btnInputFileBrowse);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(612, 74);
            this.pnlInput.TabIndex = 10;
            // 
            // tbOutputFilePath
            // 
            this.tbOutputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFilePath.Location = new System.Drawing.Point(73, 38);
            this.tbOutputFilePath.Name = "tbOutputFilePath";
            this.tbOutputFilePath.Size = new System.Drawing.Size(446, 20);
            this.tbOutputFilePath.TabIndex = 30;
            this.ToolTip.SetToolTip(this.tbOutputFilePath, "Speify text file where you want to save proccessed text.");
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(9, 40);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(58, 13);
            this.lblOutputFile.TabIndex = 21;
            this.lblOutputFile.Text = "Output file:";
            // 
            // btnOutputFileBrowse
            // 
            this.btnOutputFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputFileBrowse.Location = new System.Drawing.Point(525, 35);
            this.btnOutputFileBrowse.Name = "btnOutputFileBrowse";
            this.btnOutputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutputFileBrowse.TabIndex = 40;
            this.btnOutputFileBrowse.Text = "Browse";
            this.btnOutputFileBrowse.UseVisualStyleBackColor = true;
            this.btnOutputFileBrowse.Click += new System.EventHandler(this.btnOutputFileBrowse_Click);
            // 
            // pnlControling
            // 
            this.pnlControling.Controls.Add(this.tblControlingButtons);
            this.pnlControling.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControling.Location = new System.Drawing.Point(0, 74);
            this.pnlControling.Name = "pnlControling";
            this.pnlControling.Size = new System.Drawing.Size(612, 60);
            this.pnlControling.TabIndex = 17;
            // 
            // tblControlingButtons
            // 
            this.tblControlingButtons.ColumnCount = 3;
            this.tblControlingButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblControlingButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlingButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblControlingButtons.Controls.Add(this.btnStop, 2, 0);
            this.tblControlingButtons.Controls.Add(this.btnRun, 0, 0);
            this.tblControlingButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControlingButtons.Location = new System.Drawing.Point(0, 0);
            this.tblControlingButtons.Name = "tblControlingButtons";
            this.tblControlingButtons.RowCount = 1;
            this.tblControlingButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlingButtons.Size = new System.Drawing.Size(612, 60);
            this.tblControlingButtons.TabIndex = 17;
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(197, 157);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(13, 13);
            this.lblChars.TabIndex = 11;
            this.lblChars.Text = "--";
            this.lblChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(197, 209);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(13, 13);
            this.lblLines.TabIndex = 9;
            this.lblLines.Text = "--";
            this.lblLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Location = new System.Drawing.Point(197, 235);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(13, 13);
            this.lblSentences.TabIndex = 12;
            this.lblSentences.Text = "--";
            this.lblSentences.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(197, 183);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(13, 13);
            this.lblWords.TabIndex = 10;
            this.lblWords.Text = "--";
            this.lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSentNum
            // 
            this.lblSentNum.AutoSize = true;
            this.lblSentNum.Location = new System.Drawing.Point(12, 235);
            this.lblSentNum.Name = "lblSentNum";
            this.lblSentNum.Size = new System.Drawing.Size(111, 13);
            this.lblSentNum.TabIndex = 4;
            this.lblSentNum.Text = "Number of sentences:";
            // 
            // lblWordNum
            // 
            this.lblWordNum.AutoSize = true;
            this.lblWordNum.Location = new System.Drawing.Point(12, 183);
            this.lblWordNum.Name = "lblWordNum";
            this.lblWordNum.Size = new System.Drawing.Size(90, 13);
            this.lblWordNum.TabIndex = 3;
            this.lblWordNum.Text = "Number of words:";
            // 
            // lblLineNum
            // 
            this.lblLineNum.AutoSize = true;
            this.lblLineNum.Location = new System.Drawing.Point(12, 209);
            this.lblLineNum.Name = "lblLineNum";
            this.lblLineNum.Size = new System.Drawing.Size(83, 13);
            this.lblLineNum.TabIndex = 7;
            this.lblLineNum.Text = "Number of lines:";
            // 
            // lblCharNum
            // 
            this.lblCharNum.AutoSize = true;
            this.lblCharNum.Location = new System.Drawing.Point(12, 157);
            this.lblCharNum.Name = "lblCharNum";
            this.lblCharNum.Size = new System.Drawing.Size(112, 13);
            this.lblCharNum.TabIndex = 6;
            this.lblCharNum.Text = "Number of characters:";
            // 
            // ofdOpenOutputFile
            // 
            this.ofdOpenOutputFile.CheckFileExists = false;
            this.ofdOpenOutputFile.Filter = "Text File (*.txt)|*.txt";
            // 
            // TextProcessorView
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(612, 292);
            this.Controls.Add(this.lblCharNum);
            this.Controls.Add(this.lblLineNum);
            this.Controls.Add(this.pnlControling);
            this.Controls.Add(this.lblWordNum);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblSentNum);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblChars);
            this.Controls.Add(this.lblSentences);
            this.Controls.Add(this.lblLines);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "TextProcessorView";
            this.Text = "Text Processor (Jiri Kostiha)";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlControling.ResumeLayout(false);
            this.tblControlingButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputFileBrowse;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox tbInputFilePath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog ofdOpenInputFile;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlControling;
        private System.Windows.Forms.TableLayoutPanel tblControlingButtons;
        private System.Windows.Forms.ToolStripProgressBar pbProgress;
        private System.Windows.Forms.TextBox tbOutputFilePath;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.Button btnOutputFileBrowse;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblSentNum;
        private System.Windows.Forms.Label lblWordNum;
        private System.Windows.Forms.Label lblLineNum;
        private System.Windows.Forms.Label lblCharNum;
        private System.Windows.Forms.OpenFileDialog ofdOpenOutputFile;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

